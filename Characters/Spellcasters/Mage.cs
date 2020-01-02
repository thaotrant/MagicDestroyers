using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Equipments;
using Enumerations;

namespace Characters
{
    public class Mage : Spellcaster
    {
        //DEFAULT VALUE
        private const string DEFAULT_NAME = "Mage 1";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private const int DEFAULT_LEVEL = 5;
        private const int DEFAULT_HEALTHPOINTS = 120;
        private const int DEFAULT_MANA_POINTS = 90;

        private readonly Staff DEFAULT_STAFF_WEAPON = new Staff();
        private readonly ClothRobe DEFAULT_CLOTHROBE_ARMOR = new ClothRobe();
        
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
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoint;
            base.ManaPoints = DEFAULT_MANA_POINTS;
            base.Faction = DEFAULT_FACTION;
            base.BodyArmor = DEFAULT_CLOTHROBE_ARMOR;
            base.Weapon = DEFAULT_STAFF_WEAPON;
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
