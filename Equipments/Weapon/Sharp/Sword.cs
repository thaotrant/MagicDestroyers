using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipments
{
    public class Sword : Weapon
    {        
        private int _bloodthirst;             
        public int BloodThirst
        {
            get
            {
                return _bloodthirst;
            }
            set
            {
                _bloodthirst = value;
            }
        }
    }
}
