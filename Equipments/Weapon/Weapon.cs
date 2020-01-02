using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipments
{
    public class Weapon
    {
        private int _damage;
        public int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                if (value >= 1)
                {
                    _damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage is out of range. It must be greater than 0.");
                }
            }
        }
    }
}
