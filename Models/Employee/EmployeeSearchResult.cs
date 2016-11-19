using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Course4_1_ye_yang.Models
{
    /// <summary>
    /// 查詢結果
    /// </summary>
    public class EmployeeSearchResult
    {
        /// <summary>
        /// 員工編號
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// 員工姓名
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// 職稱
        /// </summary>
        public string CodeType { get; set; }

        /// <summary>
        /// 任職日期
        /// </summary>
        public string HireDate { get; set; }

        /// <summary>
        /// 性別
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 年齡
        /// </summary>
        public int Age { get; set; }
        
    }
}