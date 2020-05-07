using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Models.Home
{
    public class CaptchaVM
    {
        public long PublicKey { get; set; }
        public string Image { get; set; }
    }
}
