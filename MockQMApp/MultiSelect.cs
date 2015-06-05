using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockQMApp
{
    public class MultiSelect
    {
        public string cIconPfad { get; set; } // Name of the Icon
        public string cText { get; set; } // Text to display in ListView
        public bool bSelect { get; set; } // Flag, if item is selected or not
        public int iIndex { get; set; } // Own index to handle the entrys -> see code
        public string cWebServiceAufruf { get; set; } // Only relevant for my app (string for Web service call
    }
}
