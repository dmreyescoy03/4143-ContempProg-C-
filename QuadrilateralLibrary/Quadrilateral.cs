using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralLibrary
{
    //Abstract base class
    public abstract class Quadrilateral
    {
        //method for Perimeter
        public virtual double Perimeter()
        {
            return 0;
        }
        //method for Area
        public virtual double Area()
        {
            return 0;
        }
        //method for Shape name
        public abstract string Name
        {
            get;
        }
    }
    
}
