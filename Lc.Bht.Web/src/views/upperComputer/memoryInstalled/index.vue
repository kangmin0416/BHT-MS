<template>
  <div class="app-container">
    <!-- 标题 -->
    <div class="head-title">安装内存</div>

    <!-- 操作 -->
    <div class="titleText">人工安装内存</div>
    <div class="transverseline"></div>
    <div class="display-flex">
      <div style="width: 800px">
        <el-form ref="form" :model="form" :rules="rules" label-width="120px" size="medium">
          <el-row>
            <el-col :span="12">
              <el-form-item label="主板SN" maxlength="200" prop="pcb_sn">
                <el-input v-model="form.pcb_sn" placeholder="请输入主板SN" clearable />
              </el-form-item>
            </el-col>
            <el-col :span="12">
              <el-form-item label="操作码" prop="op_flag">
                <el-input v-model="form.op_flag" placeholder="请输入操作码" clearable />
              </el-form-item>
            </el-col>
            <el-col :span="12">
              <el-form-item label="内存SN" maxlength="200" prop="memo_sn">
                <el-input v-model="form.memo_sn" placeholder="请输入内存SN" clearable />
              </el-form-item>
            </el-col>
            <el-col :span="12">
              <el-form-item label="设备SN" prop="device_sn">
                <el-input v-model="form.device_sn" placeholder="请输入设备SN" clearable />
              </el-form-item>
            </el-col>
            <el-col :span="12">
              <el-form-item label="载具SN" maxlength="200" prop="con_sn">
                <el-input v-model="form.con_sn" placeholder="请输入载具SN" clearable />
              </el-form-item>
            </el-col>
            <el-col :span="12">
              <el-form-item label="工位SN" prop="work_sn">
                <el-input v-model="form.work_sn" placeholder="请输入工位SN" clearable />
              </el-form-item>
            </el-col>
            <el-col :span="12">
              <el-form-item>
                <el-button type="primary" @click="submitForm()">提交</el-button>
                <el-button @click="resetForm('ruleForm')">重置</el-button>
              </el-form-item>
            </el-col>
            <!-- <el-form-item>
              <el-button type="primary" @click="submitForm()">提交</el-button>
              <el-button @click="resetForm('ruleForm')">重置</el-button>
            </el-form-item>-->
          </el-row>
        </el-form>
      </div>
      <div class="vue-qr">
        <vue-qr
          :size="160"
          :margin="0"
          :auto-color="true"
          :dot-scale="1"
          text="156007"
          :logo-margin="2"
          :logo-corner-radius="2"
          :logo-scale="0.15"
          @keyup.enter.native="handleQuery"
        />
      </div>
    </div>

    <!-- 表格内容设置 -->
    <div class="titleText">
      <span>历史信息</span>
    </div>
    <div class="transverseline"></div>
    <el-row>
      <el-table
        v-loading="loading"
        :data="tabledData"
        row-key="id"
        border
        :default-sort="{ prop: queryParams.orderby, order: queryParams.sort }"
        @sort-change="handleSortable"
      >
        <el-table-column type="index" :index="handleIndexCalc" label="#" align="center" />
        <el-table-column prop="memo_sn" label="内存SN" sortable :show-overflow-tooltip="true" />
        <el-table-column prop="memo_loc" label="内存点位" sortable :show-overflow-tooltip="true" />
        <el-table-column prop="memo_code" label="内存料号" sortable :show-overflow-tooltip="true" />
        <el-table-column prop="result_flag" label="OK/NG" sortable :show-overflow-tooltip="true" />
        <el-table-column prop="result_message" label="返回结果" sortable :show-overflow-tooltip="true" />
        <el-table-column prop="creation_time" label="创建时间" sortable align="center" />
      </el-table>
      <pagination
        v-show="total > 0"
        :total="total"
        :page.sync="queryParams.pageIndex"
        :limit.sync="queryParams.pageSize"
        @pagination="getList"
      />
    </el-row>
  </div>
</template>

<script>
import VueQr from 'vue-qr'
import { GetHistory, InstallMemory } from '@/api/upperComputer/memory'
export default {
  name: 'memory-installed',
  components: {
    VueQr
  },
  data() {
    return {
      // 遮罩层
      loading: false,
      //主板上料历史数据
      tabledData: [],
      // 总条数
      total: 0,
      // 查询参数
      queryParams: {
        pageIndex: 1,
        pageSize: 10,
        orderby: 'creation_time',
        sort: 'descending'
      },
      timer: null,
      // 表单
      form: {
        pcb_sn: '',
        memo_sn: '',
        con_sn: 'con_sn001',
        op_flag: 'B03',
        device_sn: 'dsn001',
        work_sn: 'Memory'
      },
      // 表单校验
      rules: {
        pcb_sn: [{ required: true, message: '任务名称不能为空', trigger: 'blur' }],
        memo_sn: [{ required: true, message: '任务名称不能为空', trigger: 'blur' }],
        con_sn: [{ required: true, message: '任务名称不能为空', trigger: 'blur' }]
      }
    }
  },
  created() {
    this.getList()
  },
  mounted() {
    this.timer = setInterval(() => {
      this.getList()
    }, 1000 * 120)
    this.$once('hook:beforeDestroy', () => {
      clearInterval(this.timer)
    })
  },
  methods: {
    //查询历史数据
    getList() {
      GetHistory(this.queryParams).then(response => {
        if (response.code === 200) {
          this.tabledData = response.data.dataSource
          this.total = response.data.totalCount
        }
      })
    },

    // 自动计算分页 Id
    handleIndexCalc(index) {
      return (this.queryParams.pageIndex - 1) * this.queryParams.pageSize + index + 1
    },
    // 排序操作
    handleSortable(val) {
      this.queryParams.orderby = val.prop
      this.queryParams.sort = val.order
      this.getList()
    },
    install() {
      this.open = true
      this.title = '安装内存'
    },
    submitForm() {
      this.$refs.form.validate(valid => {
        if (valid) {
          InstallMemory(this.form).then(response => {
            if (response.code === 200) {
              this.$message({
                message: '安装成功',
                type: 'success'
              })
              this.getList()
              this.$refs.form.resetFields()
            }
          })
        }
      })
    },
    // 取消按钮
    cancel() {
      this.open = false
      this.$refs.form.resetFields()
    }
  }
}
</script>
