using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi2.Models;

namespace webapi2.Controllers
{
    public class EmployeeController : ApiController
    {
        public IHttpActionResult GetEmp(int id)
        {
            ZensarDBEntities ze = new ZensarDBEntities();
            var result = ze.GetSalaryById(id).ToList();
            return Ok(result);
        }
    }
}