using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW1
{
    class Bus
    {
        public int id;
        public string driver;
        public int route;
        public bool onRoute;

        public Bus(int id, string driver, int route)
        {
            this.id = id;
            this.driver = driver;
            this.route = route;
            this.onRoute = false;
        }
    }
}
