using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Models.Home
{
    public class SignatureCaptcha
    {
        public long PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public DateTime Expire { get; set; }
    }
}
