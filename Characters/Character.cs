using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerations;
using Interface;
using Equipments;
using Magic_Destroyers;

namespace Characters
{
    public abstract class Character : IAttacking, IDefending
    {
        // FIELD
        private int _healthPoints;
        private int _level;
        private int _score;

        private bool _isAlive;       

        private Faction _faction;
        private string _name;

        private Armor _armor;
        private Weapon _weapon;

        public virtual int HealthPoints
        {
            get
            {
                return this._healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 150)
                {
                    this._healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Health point of {Name} is out of range. It must be between 0 and 10.");
                }
            }
        }
        public virtual int Level
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

        public Armor BodyArmor 
        { 
            get
            {
                return this._armor;
            }
            set
            {
                this._armor = value;
            }
        }

        public Weapon Weapon 
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
        public bool IsAlive 
        {
            get
            {
                return this._isAlive;
            }
            set
            {
                this._isAlive = value;
            }
        }
        public int Score 
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
            }
        }
        public abstract int Attack();

        public abstract int Defend();

        public abstract int SpecialAttack();

        public void TakeDamage(int damage, string attackName, string type)
        {
            if(this.Defend() < damage)
            {
                this._healthPoints = this._healthPoints - damage + this.Defend();
                if(this._healthPoints <= 0)
                {
                    this._isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha! Your damage is not enough to harm me!");
            }
            if(!this._isAlive)
            {
                Tools.TypeSpecificColorfulCW($"{this._name} received {damage} damage from {attackName}, and is now dead!", type);
            }
            else
            {
                Tools.TypeSpecificColorfulCW($"{this._name} received {damage} damage from {attackName}, and is has {this._healthPoints} healthpoints!", type);
            }
        }
        public void WonBattle()
        {
            this._score++;
            if(this._score % 10 == 0)
            {
                this._level++;
            }
        }
    }
}
