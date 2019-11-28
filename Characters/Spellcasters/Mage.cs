using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic_Destroyers.Equipments.Armor;
using Magic_Destroyers.Equipments.Weapon;

namespace Magic_Destroyers.Characters.Spellcasters
{
    class Mage
    {
        //DEFAULT VALUE
        private const string DEFAULT_NAME = "Mage 1";
        private const int DEFAULT_LEVEL = 5;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_ABILITYPOINTS = 90;

        private readonly Staff DEFAULT_STAFF_WEAPON = new Staff();
        private readonly ClothRobe DEFAULT_CLOTHROBE_ARMOR = new ClothRobe();
        // FIELD
        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private string _faction;
        private string _name;

        private ClothRobe _bodyArmor;
        private Staff _weapon;
        //prop
        public int AbilityPoints
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
                    throw new ArgumentOutOfRangeException(string.Empty, $"Ability point of {Name} is out of range. It must be between 0 and 30.");
                }
            }
        }
        public int HealthPoints
        {
            get
            {
                return this._healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
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
        public int Level
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

        public string Faction
        {
            get
            {
                return this._faction;
            }
            set
            {
                if (value == "Melee" || value == "SpellCasters")
                {
                    this._faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Faction of {Name} must be either Melee or SpellCasters.");
                }
            }
        }
        public ClothRobe BodyArmor
        {
            get
            {
                return this._bodyArmor;
            }
            set
            {
                this._bodyArmor = value;
            }
        }
        public Staff Weapon
        {
            get
            {
                return this._weapon;
            }
            set
            {
                this._weapon = value;
            }
        }
        //ctor
        public Mage()
           : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }
        public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS)
        {
        }

        public Mage(string name, int level, int healthPoint)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoint;
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Faction = "Mage";
            this.BodyArmor = DEFAULT_CLOTHROBE_ARMOR;
            this.Weapon = DEFAULT_STAFF_WEAPON;
        }

        //Method
        public void ArcaneWrath()
        {

        }
        public void Firewall()
        {

        }
        public void Meditation()
        {

        }
    }
}
