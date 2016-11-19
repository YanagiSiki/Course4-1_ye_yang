using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course4_1_ye_yang.Models
{
    public class TableFactory
    {
        /// <summary>
        /// 將DataTable轉型為List<EmployeeSearchResult> for EmployeeSearchResult
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<EmployeeSearchResult> Table2EmployeeSearchResult(DataTable dt)
        {
            List<EmployeeSearchResult> result = new List<EmployeeSearchResult>();
            foreach (DataRow row in dt.Rows)
            {
                //string tmpGender;
                //if (row["Gender"].ToString() == "M")                
                //    tmpGender = "Male";                
                //else 
                //    tmpGender = "Female";
                result.Add(new EmployeeSearchResult()
                {
                    EmployeeId = (int)row["EmployeeId"],
                    EmployeeName = row["EmployeeName"].ToString(),
                    CodeType = row["Type"].ToString(),
                    HireDate = row["HireDate"].ToString(),
                    Gender = row["Gender"].ToString(),
                    Age = (int)row["Age"]
                });
            }
            return result;
        }

        /// <summary>
        ///將DataTable轉型為List<SelectListItem> for下拉選單
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<SelectListItem> Table2SelectListItem(DataTable dt)
        {
            List<SelectListItem> result = new List<SelectListItem>();
            foreach (DataRow row in dt.Rows)
            {
                result.Add(new SelectListItem()
                {
                    Text = row["CodeVal"].ToString(),
                    Value = row["CodeId"].ToString()
                });
            }
            return result;
        }

        /// <summary>
        /// 將DataTable轉型為EmployeeInsertArg for update
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static Employee Table2EmployeeInsertArg(DataTable dt)
        {
            Employee result = new Employee();
            result.LastName = dt.Rows[0]["LastName"].ToString();
            result.FirstName = dt.Rows[0]["FirstName"].ToString();
            result.Title = dt.Rows[0]["Title"].ToString();
            result.TitleOfCourtesy = dt.Rows[0]["TitleOfCourtesy"].ToString();
            result.BirthDate = (DateTime)dt.Rows[0]["BirthDate"];
            result.HireDate = (DateTime)dt.Rows[0]["HireDate"];
            result.Address = dt.Rows[0]["Address"].ToString();
            result.City = dt.Rows[0]["City"].ToString();
            result.Country = dt.Rows[0]["Country"].ToString();
            result.Phone = dt.Rows[0]["Phone"].ToString();
            result.ManagerID = dt.Rows[0]["ManagerID"].ToString();
            result.Gender = dt.Rows[0]["Gender"].ToString();
            result.MonthlyPayment = dt.Rows[0]["MonthlyPayment"] == DBNull.Value ? 0 : (int)dt.Rows[0]["MonthlyPayment"];
            result.YearlyPayment = dt.Rows[0]["YearlyPayment"] == DBNull.Value ? 0 : (int)dt.Rows[0]["YearlyPayment"];
            return result;
        }
    }
}