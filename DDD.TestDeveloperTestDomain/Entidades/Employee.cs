using System;
using System.Collections.Generic;

namespace DDD.TestDeveloperTestDomain.Entidades
{
    public partial class Employee
    {
        public int Id { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Office { get; set; }
        public string? EmployeeCode { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeSurname { get; set; }
        public int? Division { get; set; }
        public int? Position { get; set; }
        public int? Grade { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? Birthday { get; set; }
        public string? IdentificationNumber { get; set; }
        public decimal? BaseSalary { get; set; }
        public decimal? ProductionBonus { get; set; }
        public decimal? CompensationBonus { get; set; }
        public decimal? Commision { get; set; }
        public decimal? Contributions { get; set; }

        public virtual Division? DivisionNavigation { get; set; }
        public virtual Office? OfficeNavigation { get; set; }
        public virtual Position? PositionNavigation { get; set; }
    }
}
