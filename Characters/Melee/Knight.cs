using System;
using Magic_Destroyers.Equipments.Weapon;
using Magic_Destroyers.Equipments.Armor;
using Magic_Destroyers.Enumerations;

namespace Magic_Destroyers.Characters.Melee
{
    class Knight
    {
        //DEFAULT VALUE
        private const string DEFAULT_NAME = "Knight 1";
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private const int DEFAULT_LEVEL = 10;
        private const int DEFAULT_HEALTHPOINTS = 100;
        private const int DEFAULT_ABILITYPOINTS = 90;
        
        private readonly Hammer DEFAULT_HAMMER_WEAPON = new Hammer();
        private readonly Chainlink DEFAULT_CHAINLINK_ARMOR = new Chainlink();
        // FIELD
        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private Faction _faction;
        private string _name;

        private Chainlink _bodyArmor;
        private Hammer _weapon;
        // prop
        public int AbilityPoints
        {
            get
            {
                return this._abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this._abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Ability point of {Name} is out of range. It must be between 0 and 20");
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
                if (value >= 0 && value <= 130)
                {
                    this._healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Health point of {Name} is out of range. It must be between 0 and 30.");
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
                if (value.Length >= 2 && value.Length <= 12)
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
        public Chainlink BodyArmor
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
        public Hammer Weapon
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
        public Knight()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }
        public Knight(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS)
        {
        }

        public Knight(string name, int level, int healthPoint)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoint;
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_CHAINLINK_ARMOR;
            this.Weapon = DEFAULT_HAMMER_WEAPON;
        }
        //Method
        public void HolyBlow()
        {

        }
        public void PurifySoul()
        {

        }
        public void RighteousWings()
        {

        }
    }
}
