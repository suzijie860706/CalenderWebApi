//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace CalenderWebApi.ActionFilter
//{
//    public class JwtAuthFilter : ActionFilterAttribute
//    {
//        public override void OnActionExecuting(ActionExecutingContext filterContext)
//        {
//            string secret = "myJwtAuthDemo";
//            var request = filterContext.RequestContext;
            
//            //if (!WithoutVerifyToken(request.RequestUri.ToString()))
//            //{
//            //    if (request.Headers.Authorization == null || request.Headers.Authorization.Scheme != "Bearer")
//            //    {
//            //        throw new System.Exception("Lost Token");
//            //    }
//            //    else
//            //    {
//            //        //解密後會回傳Json格式的物件(即加密前的資料)
//            //        var jwtObject = Jose.JWT.Decode<Dictionary<string, Object>>(
//            //        request.Headers.Authorization.Parameter,
//            //        Encoding.UTF8.GetBytes(secret),
//            //        JwsAlgorithm.HS512);

//            //        if (IsTokenExpired(jwtObject["Exp"].ToString()))
//            //        {
//            //            throw new System.Exception("Token Expired");
//            //        }
//            //    }
//            //}

//            base.OnActionExecuting(filterContext);
//        }
//    }
//}