<template>
  <div class="app-container">
    <!-- 标题 -->
    <div class="head-title">主板上料</div>

    <!-- 操作 -->
    <div class="titleText">扫码</div>
    <div class="transverseline"></div>
    <div class="display-flex">
      <div style="width: 800px">
        <el-form ref="ruleForm" :model="ruleForm" :rules="rules" label-width="120px" class="demo-ruleForm el-forms" size="medium">
          <el-form-item>
            <el-input v-model="Ewm" clearable placeholder="请扫描主板SN或MAC地址" @keyup.enter.native="scanCodes" />
          </el-form-item>
          <el-col :span="12">
            <el-form-item label="主板SN" prop="pro_sn">
              <el-input v-model="ruleForm.pro_sn" disabled />
            </el-form-item>
          </el-col>
          <el-col :span="12">
            <el-form-item label="操作码" prop="op_flag">
              <el-input v-model="ruleForm.op_flag" disabled />
            </el-form-item>
          </el-col>
          <el-col :span="12">
            <el-form-item label="主板MAC地址" prop="mac_sn">
              <el-input v-model="ruleForm.mac_sn" disabled />
            </el-form-item>
          </el-col>
          <el-col :span="12">
            <el-form-item label="设备SN" prop="device_sn">
              <el-input v-model="ruleForm.device_sn" disabled />
            </el-form-item>
          </el-col>
          <el-col :span="12">
            <el-form-item label="托盘号" prop="tray">
              <el-input v-model="ruleForm.tray" disabled />
            </el-form-item>
          </el-col>
          <el-col :span="12">
            <el-form-item label="工位SN" prop="work_sn">
              <el-input v-model="ruleForm.work_sn" disabled />
            </el-form-item>
          </el-col>
          <!-- <el-form-item>
            <el-button type="primary" @click="submitForm()">提交</el-button>
            <el-button @click="resetForm('ruleForm')">重置</el-button>
          </el-form-item>-->
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
    <div class="titleText">历史信息</div>
    <div class="transverseline"></div>
    <el-row>
      <el-table
        v-loading="loading"
        :data="tabledData"
        row-key="id"
        stripe
        border
        :default-sort="{ prop: queryParams.orderby, order: queryParams.sort }"
        @sort-change="handleSortable"
      >
        <el-table-column type="index" :index="handleIndexCalc" label="#" align="center" />
        <el-table-column prop="tray" label="托盘号" sortable :show-overflow-tooltip="true" />
        <el-table-column prop="order_no" label="订单号" sortable :show-overflow-tooltip="true" />
        <el-table-column prop="pro_sn" label="主板SN" sortable :show-overflow-tooltip="true" />
        <el-table-column prop="mac_sn" label="主板mac" sortable :show-overflow-tooltip="true" />
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
import { pcbLoadMaterla, GetHistory } from '@/api/upperComputer/pcbloadmaterlal'
export default {
  name: 'pcbloadmaterlal',
  components: {
    VueQr
  },
  data() {
    return {
      // 遮罩层
      loading: false,
      //扫码信息
      Ewm: '',
      //提交信息
      ruleForm: {
        pro_sn: '', //主板sn
        mac_sn: '', //主板mac
        tray: '', //托盘号
        op_flag: 'B01', //操作码
        device_sn: 'AZBL01PCB01', //设备sn
        work_sn: 'AUTO_PCB' //工位sn
      },

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
      //提交验证
      rules: {
        pro_sn: [
          {
            required: true,
            message: '请输入主板SN',
            trigger: 'blur'
          }
        ],
        mac_sn: [
          {
            required: true,
            message: '请输入主板MAC地址',
            trigger: 'blur'
          }
        ],
        tray: [
          {
            required: true,
            message: '请输入托盘号',
            trigger: 'blur'
          }
        ]
      }
    }
  },
  created() {},
  methods: {
    //扫码
    scanCodes() {
      let ewmSubstring = this.Ewm.substring(0, 2)
      console.log(ewmSubstring)
      if (ewmSubstring == 'sn') {
        console.log(1)
        this.ruleForm.pro_sn = this.Ewm
        this.Ewm = ''
      } else if (ewmSubstring == 'ma') {
        this.ruleForm.mac_sn = this.Ewm
        this.Ewm = ''
      } else if (ewmSubstring == 'tp') {
        this.ruleForm.tray = this.Ewm
        this.Ewm = ''
      }
      if (this.ruleForm.pro_sn != '' && this.ruleForm.mac_sn != '' && this.ruleForm.tray != '') {
        this.submitForm()
      }
    },
    //提交
    submitForm() {
      this.$refs.ruleForm.validate(valid => {
        if (valid) {
          this.loading = true
          pcbLoadMaterla(this.ruleForm).then(response => {
            if (response.code === 200) {
              this.$message({
                message: '扫码成功',
                type: 'success'
              })
              this.getList()
              this.Ewm = ''
              this.resetForm('ruleForm')
              this.loading = false
            }
          })
        }
      })
    },

    //查询历史数据
    getList() {
      GetHistory(this.queryParams).then(response => {
        if (response.code === 200) {
          this.tabledData = response.data.dataSource
          this.total = response.data.totalCount
        }
      })
    },
    //重置
    resetForm(formName) {
      this.$refs.ruleForm.resetFields()
      this.Ewm = ''
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
    }
  }
}
</script>
