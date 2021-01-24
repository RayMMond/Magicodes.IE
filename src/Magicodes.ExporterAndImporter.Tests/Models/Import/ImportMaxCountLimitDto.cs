﻿// ======================================================================
// 
//           filename : ExportTestData.cs
//           description :
// 
//           created by 雪雁 at  2019-11-05 20:02
//           文档官网：https://docs.xin-lai.com
//           公众号教程：麦扣聊技术
//           QQ群：85318032（编程交流）
//           Blog：http://www.cnblogs.com/codelove/
// 
// ======================================================================

using Magicodes.ExporterAndImporter.Core;
using Magicodes.ExporterAndImporter.Excel;
using System.ComponentModel.DataAnnotations;

namespace Magicodes.ExporterAndImporter.Tests.Models.Import
{
    /// <summary>
    ///     在Excel导出中，Name将为Sheet名称
    ///     在HTML、Pdf、Word导出中，Name将为标题
    /// </summary>
    [ExcelExporter(Name = "通用导出测试", Author = "雪雁", AutoFitMaxRows = 5000)]
    [ExcelImporter(MaxCount = int.MaxValue)]
    public class ImportMaxCountLimitDto
    {
        /// <summary>
        /// </summary>
        [Display(Name = "列1")]
        [ImporterHeader(Name = "列1")]
        public string Name1 { get; set; }

        [ExporterHeader(DisplayName = "列2")]
        [ImporterHeader(Name = "列2")]
        public string Name2 { get; set; }

        public string Name3 { get; set; }
        public string Name4 { get; set; }
    }
}