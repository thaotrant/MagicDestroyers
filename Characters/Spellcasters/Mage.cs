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
    public class Mage : Spellcaster
    {
        //DEFAULT VALUE

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
           : this(Consts.Mage.NAME, Consts.Mage.LEVEL)
        {

        }
        public Mage(string name, int level)
            : this(name, level, Consts.Mage.HEALTHPOINTS)
        {
        }

        public Mage(string name, int level, int healthPoint)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoint;
            base.ManaPoints = Consts.Mage.MANA_POINTS;
            base.Faction = Consts.Mage.FACTION;
            base.BodyArmor = DEFAULT_CLOTHROBE_ARMOR;
            base.Weapon = DEFAULT_STAFF_WEAPON;
            base.IsAlive = true;
            base.Score = 0;
        }

        //Method
        public int Fireball()
        {
            return base.Weapon.Damage + 10;            
        }
        public int ArcaneWrath()
        {
            throw new NotImplementedException();
        }
       
        public int Meditation()
        {
            return base.BodyArmor.ArmorPoint + 5;
        }

        public override int Attack()
        {
            return this.Fireball();
        }

        public override int Defend()
        {
            return Meditation();
        }

        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }
    }
}
