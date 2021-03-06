//------------------------------------------------------------------------------
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
    ///托盘表
    ///</summary>
    [SugarTable("pp_tray")]
    public class PpTray
    {
          public PpTray()
          {
          }

           /// <summary>
           /// 描述 : id 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "id")]           
           [SugarColumn(IsPrimaryKey=true)]
           public string id {get;set;}

           /// <summary>
           /// 描述 : 托盘号 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "托盘号")]           
           public string tray {get;set;}

           /// <summary>
           /// 描述 : 主板id 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "主板id")]           
           public string pcb_id {get;set;}

           /// <summary>
           /// 描述 : 工站 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "工站")]           
           public string workstation {get;set;}

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