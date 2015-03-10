
namespace _02.StudentsAndWorkers
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay = 8, int workDays = 5)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkDays = workDays;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public decimal WeekSalary { get; set; }
        public decimal WorkHoursPerDay { get; set; }
        public int WorkDays { get; set; }

        public decimal MoneyPerHour()
        {
            decimal daySalary = this.WeekSalary / this.WorkDays;

            decimal salaryPerHour = daySalary / this.WorkHoursPerDay;

            return salaryPerHour;
        }
        public override string ToString()
        {
            StringBuilder workerInfo = new StringBuilder();

            workerInfo.Append(base.ToString());
            workerInfo.Append(" Work hours per day: " + this.WorkHoursPerDay);
            workerInfo.Append(" Work days: " + this.WorkDays);
            workerInfo.Append(" Week salary: " + this.WeekSalary);

            return workerInfo.ToString();
        }
    }
}
