using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipments
{
    public class Axe : Weapon
    {
        private int _hackNSlash;
       
        public int HackNSlash
        {
            get
            {
                return _hackNSlash;
            }
            set
            {
                _hackNSlash = value;
            }
        }
    }
}
