using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penta_Course02 {
    class Door {
        private string color;

        public Door(string color) {
            this.color = color;
        }

        public string Color {
            get { return this.color; }
            set { this.color = value; }
        }

        public void showData() {
            Console.WriteLine("I am a door, my color is " + this.color);
        }

        public override string ToString() {
            return "door who has color " + this.color;
        }
    }
}
