using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CalenderWebApi.Models;
using System.Threading.Tasks;
//---FireBase資料庫命名空間---
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace CalenderWebApi.FireBase
{
    public class FireBase
    {
        private static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "XC0iuclznQfRETQdoZ0kPDg6nJ3ws0YhhPwSFWM8",
            BasePath = "https://test1-5be08.firebaseio.com/"
        };
        private static FirebaseClient Client = new FirebaseClient(config);
        
        private async Task<LoginViewModel> AsyncGetData(LoginViewModel loginViewModel)
        {
            FirebaseResponse response = await Client.GetAsync("account/" + loginViewModel.account);
            LoginViewModel result = response.ResultAs<LoginViewModel>();
            return result;
        }
        public LoginViewModel GetData(LoginViewModel loginViewModel)
        {
            //使用task.Run() 並使用Task.WaitAll(task)
            //即可等待非同步結束才進行下一步
            var task = Task.Run(() => AsyncGetData(loginViewModel));
            Task.WaitAll(task);
            return task.Result;
        }


    }
}