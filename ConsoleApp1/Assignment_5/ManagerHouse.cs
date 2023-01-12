using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house.hanoi
{
    internal class ManagerHouse
    {
        public static List<HaNoiHouse> manageHouse = new List<HaNoiHouse>();

        Boolean run = true;

        public bool Menu()
        {

            return run;
        }
    }
}
