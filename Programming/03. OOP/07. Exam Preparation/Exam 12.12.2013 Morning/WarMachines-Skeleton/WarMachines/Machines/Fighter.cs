
namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter, IMachine
    {
        private const double defaultHealthPoints = 200;

        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defencePoints, bool stealthMode)
            : base(name, defaultHealthPoints, attackPoints, defencePoints)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode
        {
            get
            {
                return this.stealthMode;
            }
            private set
            {
                this.stealthMode = value;
            }
        }

        public void ToggleStealthMode()
        {
            if (this.StealthMode)
            {
                this.StealthMode = false;
            }
            else
            {
                this.StealthMode = true;
            }
        }

        public override string ToString()
        {
            StringBuilder fighterInfo = new StringBuilder();

            fighterInfo.Append(base.ToString());
            fighterInfo.Append(" *Stealth: ");

            if (this.StealthMode)
            {
                fighterInfo.Append("ON");
            }
            else
            {
                fighterInfo.Append("OFF");
            }

            fighterInfo.AppendLine();

            return fighterInfo.ToString();
        }
    }
}
