using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Equipments;
using Enumerations;

namespace Characters
{ 
    public class Warrior : Melee
    {
        //DEFAULT VALUE
        private const string DEFAULT_NAME = "Worrior 1";
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private const int DEFAULT_LEVEL = 5;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_ABILITYPOINTS = 110;

        private readonly Axe DEFAULT_AXE_WEAPON = new Axe();
        private readonly Chainlink DEFAULT_CHAINLINK_ARMOR = new Chainlink();
       
        //prop
        public override int AbilityPoints
        {
            get
            {
                return base.AbilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 130)
                {
                    base.AbilityPoints = value;
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
                if (value >= 0 && value <= 150)
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
        //ctor
        public Warrior()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Warrior(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS)
        {   
        }

        public Warrior(string name, int level, int healthPoint)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoint;
            base.AbilityPoints = DEFAULT_ABILITYPOINTS;
            base.Faction = DEFAULT_FACTION;
            base.BodyArmor = DEFAULT_CHAINLINK_ARMOR;
            base.Weapon = DEFAULT_AXE_WEAPON;
        }

        //Method
        public void Strike()
        {

        }
        public void Execute()
        {

        }
        public void SkinHarden()
        {

        }

        public override void Attack()
        {
            this.Strike();
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
