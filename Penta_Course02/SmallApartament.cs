using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penta_Course02 {
    class SmallApartament : Place{

        public SmallApartament(double area, Door door) {
            if(area > 50) {
                area = 50;
            }
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
            Console.WriteLine("I am a small apartament, my area is " + this.area + " m^2 with my " + this.door);
        }

        public override string ToString() {
            return "Small apartament with " + this.area + " m^2 and " + door;
        }

    }
}
