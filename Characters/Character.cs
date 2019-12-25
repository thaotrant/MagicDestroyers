using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic_Destroyers.Enumerations;
using Magic_Destroyers.Interface;

namespace Characters
{
    public abstract class Character : IAttacking, IDefending
    {
        // FIELD
        private int _healthPoints;
        private int _level;

        private Faction _faction;
        private string _name;

        public virtual int HealthPoints
        {
            get
            {
                return this._healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 150)
                {
                    this._healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Health point of {Name} is out of range. It must be between 0 and 10.");
                }
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 30)
                {
                    this._name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Name must has from 2 to 12 characters.");
                }
            }
        }
        public virtual int Level
        {
            get
            {
                return this._level;
            }
            set
            {
                if (value > 0)
                {
                    this._level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Level of {Name} must be greater than 0.");
                }
            }
        }

        public Faction Faction
        {
            get
            {
                return this._faction;
            }
            set
            {
                if (value == Faction.Melee || value == Faction.Spellcaster)
                {
                    this._faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Faction of {Name} must be either Melee or SpellCasters.");
                }
            }
        }

        public abstract void Attack();

        public abstract void Defend();

        public abstract void SpecialAttack();
    }
}
