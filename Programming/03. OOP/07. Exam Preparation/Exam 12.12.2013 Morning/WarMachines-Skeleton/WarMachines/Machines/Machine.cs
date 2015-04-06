
namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defencePoints;
        private IList<string> targets;

        public Machine(string name, double healthPoints, double attackPoints, double defencePoints)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defencePoints;

            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Pilot cannot be null");
                }

                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get 
            {
                return this.attackPoints;
            }
            protected set
            {
                this.attackPoints = value;
            }
        }

        public double DefensePoints
        {
            get 
            {
                return this.defencePoints;
            }
            protected set
            {
                this.defencePoints = value;
            }
        }

        public IList<string> Targets
        {
            get 
            {
                //IList<string> targetsCopy = new List<string>();

                //foreach (var item in this.targets)
                //{
                //    targetsCopy.Add(item);
                //}

                //return targetsCopy;

                return this.targets;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("List of targets cannot be null.");
                }
                
                this.targets = value;
            }

        }

        public void Attack(string target)
        {
            this.Targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder machineInfo = new StringBuilder();

            machineInfo.AppendLine("- " + this.Name);

            machineInfo.AppendLine(" *Type: " + this.GetType().Name);
            machineInfo.AppendLine(" *Health: " + this.HealthPoints);
            machineInfo.AppendLine(" *Attack: " + this.AttackPoints);
            machineInfo.AppendLine(" *Defense: " + this.DefensePoints);

            machineInfo.Append(" *Targets: ");
            
            if (this.Targets.Count > 0)
            {
                foreach (var tar in this.Targets)
                {
                    machineInfo.AppendFormat("{0}, ", tar);
                }

                machineInfo.Length--;
                machineInfo.Length--;

                machineInfo.AppendLine();
            }
            else if (this.Targets.Count == 0)
            {
                machineInfo.Append("None");
                machineInfo.AppendLine();
            }

            return machineInfo.ToString();
        }
    }
}
