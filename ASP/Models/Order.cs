using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LG.Models
{
    public class Order
    {
        /// <summary>
        /// 訂單編號
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 客戶代號dd
        /// </summary>
        public string CustId { get; set; }

        /// <summary>
        /// 客戶名稱
        /// </summary>
        public string CustName { get; set; }
    }
}