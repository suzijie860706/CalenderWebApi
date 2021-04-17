﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using JwtAuthDemo.Controllers;
using JwtAuthDemo.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace JwtAuthDemo.Controllers
{
    [Authorize]
    [ApiController]
    public class TokenController : Controller
    {
        [HttpPost("~/signin")]
        public ActionResult<string> SignIn(LoginViewModel login)
        {
            private readonly JwtHelpers jwt;
        }

        public TokenController(JwtHelpers jwt)
        {
            this.jwt = jwt;
        }

        [AllowAnonymous]
        [HttpPost("~/signin")]
        public ActionResult<string> SignIn(LoginViewModel login)
        {
            if (ValidateUser(login))
            {
                return jwt.GenerateToken(login.Username);
            }
            else
            {
                return BadRequest();
            }
        }

        private bool ValidateUser(LoginViewModel login)
        {
            return true; // TODO
        }

        [HttpGet("~/claims")]
        public IActionResult GetClaims()
        {
            return Ok(User.Claims.Select(p => new { p.Type, p.Value }));
        }

        [HttpGet("~/username")]
        public IActionResult GetUserName()
        {
            return Ok(User.Identity.Name);
        }

        [HttpGet("~/jwtid")]
        public IActionResult GetUniqueId()
        {
            var jti = User.Claims.FirstOrDefault(p => p.Type == "jti");
            return Ok(jti.Value);
        }
    }
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
