using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            if (other is null) return 1;

            return this.Salary.CompareTo(other.Salary);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }
    }
}
