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
    ///
    ///</summary>
    [SugarTable("pp_cpu")]
    public class PpCpu
    {
          public PpCpu()
          {
          }

           /// <summary>
           /// 描述 : 主键id 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "主键id")]           
           [SugarColumn(IsPrimaryKey=true)]
           public string id {get;set;}

           /// <summary>
           /// 描述 : 主板id 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "主板id")]           
           public string pcb_id {get;set;}

           /// <summary>
           /// 描述 : cpu_sn 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "cpu_sn")]           
           public string cpu_sn {get;set;}

           /// <summary>
           /// 描述 : cpu料号 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "cpu料号")]           
           public string cpu_code {get;set;}

           /// <summary>
           /// 描述 : cpu点位 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "cpu点位")]           
           public string cpu_loc {get;set;}

           /// <summary>
           /// 描述 : cpu坐标 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "cpu坐标")]           
           public string cpu_coor {get;set;}

           /// <summary>
           /// 描述 : cpu角度 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "cpu角度")]           
           public string cpu_ang {get;set;}

           /// <summary>
           /// 描述 : 支架料号 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "支架料号")]           
           public string sup_code {get;set;}

           /// <summary>
           /// 描述 : 散热器料号 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "散热器料号")]           
           public string rad_code {get;set;}

           /// <summary>
           /// 描述 : 相对路劲 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "相对路劲")]           
           public string img_path {get;set;}

           /// <summary>
           /// 描述 : 节拍 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "节拍")]           
           public string rhythm {get;set;}

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