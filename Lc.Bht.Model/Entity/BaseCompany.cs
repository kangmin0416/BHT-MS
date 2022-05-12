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
    ///公司定义
    ///</summary>
    [SugarTable("base_company")]
    public class BaseCompany
    {
          public BaseCompany()
          {
          }

           /// <summary>
           /// 描述 : UUID 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "UUID")]           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// 描述 : 公司编码 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "公司编码")]           
           public string CompanyNo {get;set;}

           /// <summary>
           /// 描述 : 公司名称 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "公司名称")]           
           public string CompanyName {get;set;}

           /// <summary>
           /// 描述 : 备注 
           /// 空值 : True
           /// 默认 : 
           /// </summary>
           [Display(Name = "备注")]           
           public string Remark {get;set;}

           /// <summary>
           /// 描述 : 是否启用 
           /// 空值 : False
           /// 默认 : b'1'
           /// </summary>
           [Display(Name = "是否启用")]           
           public bool Enable {get;set;}

           /// <summary>
           /// 描述 : 创建时间 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "创建时间")]           
           public DateTime CreateTime {get;set;}

           /// <summary>
           /// 描述 : 最后更新时间 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "最后更新时间")]           
           public DateTime UpdateTime {get;set;}

           /// <summary>
           /// 描述 : 创建人编码 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "创建人编码")]           
           public string CreateID {get;set;}

           /// <summary>
           /// 描述 : 创建人 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "创建人")]           
           public string CreateName {get;set;}

           /// <summary>
           /// 描述 : 更新人编码 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "更新人编码")]           
           public string UpdateID {get;set;}

           /// <summary>
           /// 描述 : 更新人 
           /// 空值 : False
           /// 默认 : 
           /// </summary>
           [Display(Name = "更新人")]           
           public string UpdateName {get;set;}

    }
}