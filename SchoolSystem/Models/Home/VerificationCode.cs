using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Models.Home
{
    public class VerificationCode
    {
        public string Mobile { get; set; }
        public string Code { get; set; }
        public DateTime Expire { get; set; }
    }
}
