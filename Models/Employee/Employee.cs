using Course4_1_ye_yang.Models.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Course4_1_ye_yang.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        /// <summary>
        /// FirstName
        /// </summary>        
        [Required(ErrorMessage = "此為必填欄位")]
        public string FirstName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        [Required(ErrorMessage = "此為必填欄位")]
        public string LastName { get; set; }

        /// <summary>
        /// 職稱
        /// </summary>
        [Required(ErrorMessage = "此為必填欄位")]
        public string Title { get; set; }

        /// <summary>
        /// 稱謂
        /// </summary>
        [Required(ErrorMessage = "此為必填欄位")]
        public string TitleOfCourtesy { get; set; }

        /// <summary>
        /// 任職日期
        /// </summary>
         [Required(ErrorMessage = "此為必填欄位")]
        public DateTime? HireDate { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
         [Required(ErrorMessage = "此為必填欄位")]
         [DatetimeFuture(ErrorMessage = "你出生在未來= =?")]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// 國家
        /// </summary>
         [Required(ErrorMessage = "此為必填欄位")]
        public string Country { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
         [Required(ErrorMessage = "此為必填欄位")]
        public string City { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
         [Required(ErrorMessage = "此為必填欄位")]
        public string Address { get; set; }

        /// <summary>
        /// 電話
        /// </summary>
         [Required(ErrorMessage = "此為必填欄位")]
        public string Phone { get; set; }

        /// <summary>
        /// 性別
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 直屬主管
        /// </summary>
        public String ManagerID { get; set; }

        /// <summary>
        /// 月薪
        /// </summary>        
        public int MonthlyPayment { get; set; }

        /// <summary>
        /// 年薪
        /// </summary>
        //[RegularExpression()] ^(([0-9]+))$
        public int YearlyPayment { get; set; }        
    }
}