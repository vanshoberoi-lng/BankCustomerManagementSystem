using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Contracts
{
    public class CustomerGreetingResponse
    {
        public string Message { get; set; } = string.Empty;
        public string CustomerTier { get; set; } = "Standard";
        public DateTime GeneratedAt { get; set; } = DateTime.Now;
    }
}
