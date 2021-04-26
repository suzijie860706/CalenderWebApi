using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalenderWebApi.Models;
using CalenderWebApi.Security;
//FireBase命名空間
using CalenderWebApi.FireBase;
namespace CalenderWebApi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public object Login(LoginViewModel loginRequest)
        {
            FireBase.FireBase Client = new FireBase.FireBase();
            LoginViewModel result = Client.GetData(loginRequest);
            //LoginViewModel result = Client.GetData(loginRequest);
            if (result == null)
            {
                return Json(new ApiError<string>("404","查無此帳號"));
            }
                if (result.password != loginRequest.password)
            {
                return Json(new ApiError<string>("404", "密碼錯誤"));
            }
            //產生Toekn
            JwtAuthUtil jwtAuthUtil = new JwtAuthUtil();
            string jwtToken = jwtAuthUtil.GenerateToken(loginRequest.account, loginRequest.password);
            return Json(new ApiResult<string>(jwtToken));
        }
        //更改密碼
        //[HttpPost]
        public string changePassword(string token, string old_password, string new_password)
        {
            if (old_password == new_password)
            {

            }
            //驗證Token
            JwtAuthUtil jwtAuthUtil = new JwtAuthUtil();
            jwtAuthUtil.verifyToken(token);
            return "變更成功!";
        }
    }
}