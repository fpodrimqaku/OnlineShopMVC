﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Database
{
    public class DatabaseExecuteResult
    {
        public bool HasError = false;
        public string ErrorMessage = string.Empty;
        public int Count = 0;
        public bool HasAffected => this.Count > 0 ? true : false;
    }
}