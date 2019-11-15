﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic_Destroyers.Equipments.Armor;
using Magic_Destroyers.Equipments.Weapon;

namespace Magic_Destroyers.Characters.Melee
{
    class Warrior
    {
        private int _abilityPoints;
        private int _healthPoints;
        private int _level;

        private string _faction;
        private string _name;

        private Chainlink _bodyArmor;
        private Axe _weapon;
        //prop
        public int AbilityPoints
        {
            get
            {
                return _abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 30)
                {
                    _abilityPoints = value;
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
                return _healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _healthPoints = value;
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
                return _name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 12)
                {
                    _name = value;
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
                return _level;
            }
            set
            {
                if (value > 0)
                {
                    _level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Level of {Name} must be greater than 0.");
                }
            }
        }

        public string Faction
        {
            get
            {
                return _faction;
            }
            set
            {
                if (value == "Melee" || value == "SpellCasters")
                {
                    _faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"Faction of {Name} must be either Melee or SpellCasters.");
                }
            }
        }
        public Chainlink BodyArmor
        {
            get
            {
                return _bodyArmor;
            }
            set
            {
                _bodyArmor = value;
            }
        }
        public Axe Weapon
        {
            get
            {
                return _weapon;
            }
            set
            {
                _weapon = value;
            }
        }
        //ctor
        public Warrior()
        {
            //tbd
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
    }
}
