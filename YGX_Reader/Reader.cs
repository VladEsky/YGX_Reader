using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Elements;

namespace YGX_Reader
{
    public class Reader
    {
        private XElement xelYGX;

        public Reader(string FileName) {
            xelYGX = XElement.Load(FileName);
        }
    }
}
