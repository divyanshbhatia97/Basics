﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Basics.Web.Controllers
{
    public class UserController : ApiController
    {
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}
	}
}
