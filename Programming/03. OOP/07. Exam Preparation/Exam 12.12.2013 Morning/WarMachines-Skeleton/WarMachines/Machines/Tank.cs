
namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    public class Tank : Machine, ITank, IMachine
    {
        private const double defaultHealthPoints = 100;
        private bool defenseMode;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, defaultHealthPoints, attackPoints, defensePoints)
        {
            this.DefenseMode = true;

            if (this.DefenseMode)
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
        }

        public bool DefenseMode
        {
            get 
            {
                return this.defenseMode;
            }
            private set
            {
                this.defenseMode = value;
            }
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.DefensePoints -= 30;
                this.AttackPoints += 40;

                this.DefenseMode = false;
            }
            else
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;

                this.DefenseMode = true;
            }
        }

        public override string ToString()
        {
            StringBuilder tankInfo = new StringBuilder();

            tankInfo.Append(base.ToString());
            tankInfo.Append(" *Defense: ");

            if (this.DefenseMode)
            {
                tankInfo.Append("ON");
            }
            else
            {
                tankInfo.Append("OFF");
            }

            tankInfo.AppendLine();

            return tankInfo.ToString();
        }
    }
}
