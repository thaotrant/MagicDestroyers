using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipments
{
    public class Armor
    {
        private int _armorPoints;
        public int ArmorPoint
        {
            get
            {
                return _armorPoints;
            }
            set
            {
                if (value >= 1)
                {
                    _armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "ArmorPoint must be greater than 0.");
                }

            }
        }
    }
}
