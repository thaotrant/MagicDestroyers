using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipments
{
    public class Hammer : Weapon
    {
        private int _stun;

        public int Stun
        {
            get
            {
                return _stun;
            }
            set
            {
                _stun = value;
            }
        }

        //ctor
        
    }
}
