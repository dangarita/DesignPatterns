using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Visitor
{
    public class Employee : Element
    {
        private string _name;
        private double _income;
        private int _vacationDays;

        // Constructor

        public Employee(string name, double income,
          int vacationDays)
        {
            this.Name = name;
            this.Income = income;
            this.VacationDays = vacationDays;
        }

        public string Name { get => _name; set => _name = value; }
        public double Income { get => _income; set => _income = value; }
        public int VacationDays { get => _vacationDays; set => _vacationDays = value; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
