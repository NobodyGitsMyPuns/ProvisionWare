using System;
using System.Collections.Generic;

namespace Cart
{
   [Serializable]
    public class Cart
    {
       
        public string userName { get; set; }
        public string OrderNumber { get; set; }
        public List<string> Items { get; set; }

        }
    }
