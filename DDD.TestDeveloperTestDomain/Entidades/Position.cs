using System;
using System.Collections.Generic;

namespace DDD.TestDeveloperTestDomain.Entidades
{
    public partial class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
        }

        public int IdPosition { get; set; }
        public string? Position1 { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
