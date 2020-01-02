using Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public abstract class Spellcaster : Character
    {
        private int _manaPoints;

        public virtual int ManaPoints
        {
            get
            {
                return this._manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 130)
                {
                    this._manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Ability point of {base.Name} is out of range. It must be between 0 and 30.");
                }
            }
        }
    }
}
