﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
//     author CHENGE
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
using System.Text;
using SqlSugar;


namespace Lc.Bht.Model
{
    ///<summary>
    ///主板表
    ///</summary>
    [SugarTable("pp_pcb")]
    public class PpPcb
    {
          public PpPcb()
          {
          }

           /// <summary>
           /// 描述 : 主键 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "主键")]           
           [SugarColumn(IsPrimaryKey=true)]
           public string id {get;set;}

           /// <summary>
           /// 描述 : 托盘id 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "托盘id")]           
           public string tray_id {get;set;}

           /// <summary>
           /// 描述 : 主板序列号 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "主板序列号")]           
           public string pro_sn {get;set;}

           /// <summary>
           /// 描述 : 主板料号 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "主板料号")]           
           public string mboard_code {get;set;}

           /// <summary>
           /// 描述 : 主板mac地址 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "主板mac地址")]           
           public string mac_sn {get;set;}

           /// <summary>
           /// 描述 : 节拍（MS） 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "节拍（MS）")]           
           public string rhythm {get;set;}

           /// <summary>
           /// 描述 : 相对路径, 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "相对路径,")]           
           public string img_path {get;set;}

           /// <summary>
           /// 描述 : 载具sn 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "载具sn")]           
           public string con_sn {get;set;}

           /// <summary>
           /// 描述 : 设备SN(plc) 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "设备SN(plc)")]           
           public string device_sn {get;set;}

           /// <summary>
           /// 描述 : 工位SN 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "工位SN")]           
           public string work_sn {get;set;}

           /// <summary>
           /// 描述 : 操作员工号 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "操作员工号")]           
           public string emp_no {get;set;}

           /// <summary>
           /// 描述 : 创建时间 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "创建时间")]           
           public DateTime? creation_time {get;set;}

           /// <summary>
           /// 描述 : 更新时间 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "更新时间")]           
           public DateTime? updata_time {get;set;}

    }
}