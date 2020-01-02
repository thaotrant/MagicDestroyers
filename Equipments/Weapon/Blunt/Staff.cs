using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipments
{
    public class Staff : Weapon
    {
        
        private int _empower;
        
        public int Empower
        {
            get
            {
                return _empower;
            }
            set
            {
                _empower = value;
            }
        }
    }
}
