using System;
using Equipments;
using Enumerations;
using Characters;

namespace Characters
{
    public class Assassin : Melee
    {
        // default values
        private const string DEFAULT_NAME = "Assassin 1";

        private const int DEFAULT_LEVEL = 5;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_ABILITYPOINTS = 100;

        private const Faction DEFAULT_FACTION = Faction.Melee;

        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();
        private readonly LightLeatherVest DEFAULT_LIGHTlEATHERVEST_ARMOR = new LightLeatherVest();    

        //Prop
        public override int AbilityPoints 
        {
            get 
            {
                return base.AbilityPoints;
            }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    base.AbilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Ability point of {base.Name} is out of range. It must be between 0 and 10.");
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
                if (value >= 0 && value <= 100)
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
                if(value > 0)
                {
                    base.Level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Level of {base.Name} must be greater than 0.");
                }
            }
        }
        //constructor
        public Assassin()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            
        }
        public Assassin(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS)
        {            
        }

        public Assassin(string name, int level, int healthPoint)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoint;
            base.AbilityPoints = DEFAULT_ABILITYPOINTS;
            base.Faction = DEFAULT_FACTION;
            base.BodyArmor = DEFAULT_LIGHTlEATHERVEST_ARMOR;
            base.Weapon = DEFAULT_SWORD_WEAPON;

        }

        //Method
        public void Raze()
        {

        }
        public void BleedToDeath()
        {

        }
        public void Survival()
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
