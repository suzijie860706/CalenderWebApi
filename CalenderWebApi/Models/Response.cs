using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalenderWebApi.Models
{
    /// <summary>
    /// API呼叫時，傳回的統一物件
    /// </summary>
    public class ApiResult<T>
    {
        /// <summary>
        /// 執行成功與否
        /// </summary>
        public bool Succ { get; set; }

        /// <summary>
        /// 結果代碼(0000=成功，其他為錯誤代碼)
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 錯誤訊息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 資料時間
        /// </summary>
        public string DataTime { get; set; }

        /// <summary>
        /// 資料本體
        /// </summary>
        public T Data { get; set; }


        public ApiResult() { }

        /// <summary>
        /// 建立成功結果
        /// </summary>
        /// <param name="data"></param>
        public ApiResult(T data)
        {
            Code = "0000";
            Succ = true;
            DataTime = DateTime.Now.ToString();
            Data = data;
        }
    }

    public class ApiError<T> : ApiResult<T>
    {
        public ApiError(string code,string message)
        {
            Succ = false;
            Code = code;
            Message = message;
            DataTime = DateTime.Now.ToString();
        }
    }
    
    
}