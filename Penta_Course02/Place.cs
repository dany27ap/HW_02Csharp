using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penta_Course02 {
    abstract class Place {
        protected double area;
        protected Door door;

        abstract public void ShowData();
    }
}
