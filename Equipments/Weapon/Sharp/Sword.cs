﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyers.Equipments.Weapon
{
    public class Sword
    {
        private int _damage;
        private int _bloodthirst;

        public int Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                if (value >= 1)
                {
                    _damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage is out of range. It must be greater than 0.");
                }
            }
        }
        public int BloodThirst
        {
            get
            {
                return _bloodthirst;
            }
            set
            {
                _bloodthirst = value;
            }
        }
    }
}
