﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EhzBattleServer.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LoginController : ControllerBase
  {
    // GET: api/<LoginController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/<LoginController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "status";
    }

    // POST api/<LoginController>
    [HttpPost]
    public string Post([FromBody] string value)
    {
      //{ "login":"rusal","password":"123"}

      string token = "secret code";
      return token;
    }

    //// PUT api/<LoginController>/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //// DELETE api/<LoginController>/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
  }
}
