using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic_Destroyers.Equipments.Armor;
using Magic_Destroyers.Equipments.Weapon;
using Magic_Destroyers.Enumerations;


namespace Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        //DEFAULT VALUE
        private const string DEFAULT_NAME = "Druid 1";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private const int DEFAULT_LEVEL = 5;
        private const int DEFAULT_HEALTHPOINTS = 100;
        private const int DEFAULT_ABILITYPOINTS = 90;

        private readonly Staff DEFAULT_STAFF_WEAPON = new Staff();
        private readonly LightLeatherVest DEFAULT_LIGHTLEATHERVEST_ARMOR = new LightLeatherVest();
        // FIELD
        private int _abilityPoints;        
        private int _healthPoints;
        private int _level;
        
        private Faction _faction;
        private string _name;
        
        private LightLeatherVest _bodyArmor;
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
        public LightLeatherVest BodyArmor
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
        public Druid()
           : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }
        public Druid(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS)
        {
        }

        public Druid(string name, int level, int healthPoint)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoint;
            this.AbilityPoints = DEFAULT_ABILITYPOINTS;
            this.Faction = DEFAULT_FACTION ;
            this.BodyArmor = DEFAULT_LIGHTLEATHERVEST_ARMOR;
            this.Weapon = DEFAULT_STAFF_WEAPON;
        }

        //Method
        public void Moonfire()
        {

        }
        public void Starburst()
        {

        }
        public void OneWithTheNature()
        {

        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }
    }
}
