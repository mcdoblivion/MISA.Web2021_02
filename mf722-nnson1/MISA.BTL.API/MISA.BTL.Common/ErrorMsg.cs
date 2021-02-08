﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.BTL.Common
{
    public class ErrorMsg
    {
        public string DevMsg { get; set; }
        public List<string> UserMsg { get; set; } = new List<string>();
        public string ErrorCode { get; set; }
        public string MoreInfo { get; set; }
        public string TraceId { get; set; }
    }
}
