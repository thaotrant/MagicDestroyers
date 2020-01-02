using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Equipments;
using Enumerations;

namespace Characters
{
    public class Necromancer : Spellcaster
    {
        //DEFAULT VALUE
        private const string DEFAULT_NAME = "Necromancer 1";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private const int DEFAULT_LEVEL = 10;
        private const int DEFAULT_HEALTHPOINTS = 110;
        private const int DEFAULT_MANA_POINTS = 90;

        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();
        private readonly LightLeatherVest DEFAULT_LIGHTLEATHERVEST_ARMOR = new LightLeatherVest();
        // FIELD       
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
                if (value >= 0 && value <= 130)
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
        public Necromancer()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }
        public Necromancer(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS)
        {

        }       
        
        public Necromancer(string name, int level, int healthPoint)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoint;
            base.ManaPoints = DEFAULT_MANA_POINTS;
            base.Faction = DEFAULT_FACTION;
            base.BodyArmor = DEFAULT_LIGHTLEATHERVEST_ARMOR;
            base.Weapon = DEFAULT_SWORD_WEAPON;
        }

        //Method
        public void ShadowRage()
        {

        }
        public void VampireTouch()
        {

        }
        public void BoneShield()
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
