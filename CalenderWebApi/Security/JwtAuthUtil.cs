using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using CalenderWebApi.Models;
using Newtonsoft.Json;

namespace CalenderWebApi.Security
{
    public class JwtAuthUtil
    {
        private string secret = "myJwtAuthDemo"; 
        public string GenerateToken(string account,string password)
        {   
            Dictionary<string, object> payload = new Dictionary<string, object>();
            payload.Add("Account", account);
            payload.Add("Exp", DateTime.Now.AddSeconds(3).ToString());
            
            string token = Jose.JWT.Encode(payload, Encoding.UTF8.GetBytes(secret), Jose.JwsAlgorithm.HS512);
            return token;
        }
        public void verifyToken(string token)
        {
            if (token == null)
            {
                throw new System.Exception("Lost Token");
            }
            else
            {
                try
                {
                    string jwtObject = Jose.JWT.Decode(token, Encoding.UTF8.GetBytes(secret), Jose.JwsAlgorithm.HS512);
                    LoginViewModel result = JsonConvert.DeserializeObject<LoginViewModel>(jwtObject);
                    DateTime dt = Convert.ToDateTime(result.Exp);
                    if (DateTime.Now > dt)
                    {
                        throw new System.Exception("權杖已到期");
                    }
                }
                catch (Exception ex)
                {
                    throw new System.Exception("Error" + ex.ToString());
                }
            }
        }
    }
}