using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropsLib;
using PropsLib.Models;

namespace Props
{
    class Program
    {
        static void Main(string[] args)
        {
            var propsViewer = new PropsModel();
            propsViewer.PushLine("const Color  blue = #0000ff");
        }
    }
}
