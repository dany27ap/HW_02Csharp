using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penta_Course02 {
    class Program {
        static void Main(string[] args) {
            Door door = new Door("yellow");
            House test = new House(153.23, door);
            House test1 = new House(112.623, door);
            House test2 = new House(12.323, door);
            House test3 = new House(23.423, door);
            SmallApartament sm = new SmallApartament(69, door);
            sm.ShowData();
            Person Adam = new Person("Adam");
            Adam.addHouse(test);
            Adam.addHouse(test1);
            Adam.addHouse(test2);
            Adam.addHouse(test3);
            Adam.addApartament(sm);
            Adam.showData();

        }
    }
}
