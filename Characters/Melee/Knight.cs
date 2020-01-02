using System;
using Equipments;
using Enumerations;
using Characters;

namespace Characters
{
    public class Knight : Melee
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
        
        // prop
        public override int AbilityPoints
        {
            get
            {
                return base.AbilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    base.AbilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Ability point of {base.Name} is out of range. It must be between 0 and 20");
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
                if (value >= 0 && value <= 130)
                {
                    base.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Health point of {Name} is out of range. It must be between 0 and 30.");
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
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoint;
            base.AbilityPoints = DEFAULT_ABILITYPOINTS;
            base.Faction = DEFAULT_FACTION;
            base.BodyArmor = DEFAULT_CHAINLINK_ARMOR;
            base.Weapon = DEFAULT_HAMMER_WEAPON;
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
