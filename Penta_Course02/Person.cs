using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penta_Course02 {
    class Person {
        private string name;
        private List<House> houses;
        private List<SmallApartament> sm;

        public Person(string name) {
            this.name = name;
            this.houses = new List<House>();
            this.sm = new List<SmallApartament>();
        }

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        public void addHouse(House house) {
            this.houses.Add(house);
        }

        public void addApartament(SmallApartament apartament) {
            this.sm.Add(apartament);
        }

        public void showData() {
            Console.WriteLine("Person: " + this.name + " has ");
            foreach(House casa in houses) {
                Console.WriteLine(casa);
            }
            foreach(SmallApartament apartament in sm) {
                Console.WriteLine(apartament);
            }
        }
    }
}
