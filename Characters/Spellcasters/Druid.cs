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
        private const int DEFAULT_MANA_POINTS = 90;

        private readonly Staff DEFAULT_STAFF_WEAPON = new Staff();
        private readonly LightLeatherVest DEFAULT_LIGHTLEATHERVEST_ARMOR = new LightLeatherVest();
        // FIELD
        private LightLeatherVest _bodyArmor;
        private Staff _weapon;
        //prop
        public override int ManaPoints
        {
            get
            {
                return base.ManaPoints;
            }
            set
            {
                if (value >= 0 && value <= 130)
                {
                    base.ManaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Ability point of {base.Name} is out of range. It must be between 0 and 30.");
                }
            }
        }
        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    base.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Health point of {base.Name} is out of range. It must be between 0 and 10.");
                }
            }
        }
       public override int Level
        {
            get
            {
                return base.Level;
            }
            set
            {
                if (value > 0)
                {
                    base.Level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Level of {base.Name} must be greater than 0.");
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
            this.ManaPoints = DEFAULT_MANA_POINTS;
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
