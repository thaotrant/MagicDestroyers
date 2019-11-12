using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Equipments.Weapon
{
    public class Hammer
    {
        private int _damage;
        private int _stun;

        public int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value; 
            }
        }
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
        //public void Stun
        //{      
        //}
    }
}
