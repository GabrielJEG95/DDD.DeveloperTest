using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DDD.TestDeveloperTestDomain.Commands
{
    public abstract class EmployeeCommands : Command
    {
        public int Id { get; protected set; }
        public int? Year { get; protected set; }
        public int? Month { get; protected set; }
        public int? Office { get; protected set; }
        public string? EmployeeCode { get; protected set; }
        public string? EmployeeName { get; protected set; }
        public string? EmployeeSurname { get; protected set; }
        public int? Division { get; protected set; }
        public int? Position { get; protected set; }
        public int? Grade { get; protected set; }
        public DateTime? BeginDate { get; protected set; }
        public DateTime? Birthday { get; protected set; }
        public string? IdentificationNumber { get; protected set; }
        public decimal? BaseSalary { get; protected set; }
        public decimal? ProductionBonus { get; protected set; }
        public decimal? CompensationBonus { get; protected set; }
        public decimal? Commision { get; protected set; }
        public decimal? Contributions { get; protected set; }
    }
}
