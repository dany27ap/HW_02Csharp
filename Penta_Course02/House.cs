using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penta_Course02 {
    class House : Place{
        
        public House(double area, Door door) {
            this.area = area;
            this.door = door;
        }

        public double Area {
            get { return this.area; }
            set { this.area = value; }
        }

        public Door Door {
            get { return this.door; }
        }

        public override void ShowData() {
            Console.WriteLine("I am a house, my area is " + this.area + " m^2 with my " + door);

        }

        public override string ToString() {
            return "House with " + this.area + " m^2 and " + door;
        }
    }
}
