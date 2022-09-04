using System;
using System.Collections.Generic;

namespace DDD.TestDeveloperTestDomain.Entidades
{
    public partial class Office
    {
        public Office()
        {
            Employees = new HashSet<Employee>();
        }

        public int IdOffice { get; set; }
        public string? Office1 { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
