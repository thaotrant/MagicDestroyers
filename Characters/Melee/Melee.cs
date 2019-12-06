using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Characters.Melee
{
    public class Melee : Character
    {
        private int _abilityPoints;

        public virtual int AbilityPoints
        {
            get
            {
                return this._abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 130)
                {
                    this._abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Ability point of {base.Name} is out of range. It must be between 0 and 30.");
                }
            }
        }
    }
}
