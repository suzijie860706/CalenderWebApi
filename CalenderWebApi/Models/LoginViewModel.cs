using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalenderWebApi.Models
{
    public class LoginViewModel
    {
        /// <summary>
        /// 帳號
        /// </summary>
        public string account { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// 到期時間
        /// </summary>
        public string Exp { get; set; }

        /// <summary>
        /// 權杖
        /// </summary>
        public string token { get; set; }
    }
}