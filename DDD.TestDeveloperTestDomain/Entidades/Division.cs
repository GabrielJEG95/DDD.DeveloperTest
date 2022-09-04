using System;
using System.Collections.Generic;

namespace DDD.TestDeveloperTestDomain.Entidades
{
    public partial class Division
    {
        public Division()
        {
            Employees = new HashSet<Employee>();
        }

        public int IdDivision { get; set; }
        public string? Division1 { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
