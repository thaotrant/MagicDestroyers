using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Equipments;
using Enumerations;
using Magic_Destroyers;

namespace Characters
{ 
    public class Warrior : Melee
    {
        //DEFAULT VALUE  
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
            : this(Consts.Warrior.NAME, Consts.Warrior.LEVEL)
        {
        }
        public Warrior(string name, int level)
            : this(name, level, Consts.Warrior.HEALTHPOINTS)
        {   
        }

        public Warrior(string name, int level, int healthPoint)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoint;
            base.AbilityPoints = Consts.Warrior.ABILITYPOINTS;
            base.Faction = Consts.Warrior.FACTION;
            base.BodyArmor = DEFAULT_CHAINLINK_ARMOR;
            base.Weapon = DEFAULT_AXE_WEAPON;
            base.Score = 0;
            base.IsAlive = true;
        }

        //Method
        public int Strike()
        {
            return base.Weapon.Damage + 10;
        }
        public int Execute()
        {
            throw new NotImplementedException();
        }
        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoint + 5;
        }

        public override int Attack()
        {
            return this.Strike();
        }

        public override int Defend()
        {
            return SkinHarden();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }
    }
}
