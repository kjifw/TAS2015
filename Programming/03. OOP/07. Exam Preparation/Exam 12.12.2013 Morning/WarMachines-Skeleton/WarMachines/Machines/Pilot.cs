
namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;

            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pilot name cannot be null");
                }

                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentNullException("Machine cannot be null");
            }

            this.machines.Add(machine);

            this.machines
                .OrderBy(x => x.HealthPoints)
                .ThenBy(x => x.Name);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();

            report.Append(this.Name + " - ");

            if (this.machines.Count == 0)
            {
                report.Append("no machines");
            }
            else if (this.machines.Count >= 1)
            {
                if (this.machines.Count == 1)
                {
                    report.Append(this.machines.Count);
                    report.Append(" machine");
                }
                else
                {
                    report.Append(this.machines.Count);
                    report.Append(" machines");
                }

                report.AppendLine();

                foreach (var mach in this.machines)
                {
                    report.Append(mach);
                }
            }

            return report.ToString();
        }
    }
}
