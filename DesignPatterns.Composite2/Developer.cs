﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Composite2
{
    public class Developer : IEmployee
    {
        private readonly long empId;
        private readonly string name;
        private readonly string position;

        public string Position => position;

        public string Name => name;

        public long EmpId => empId;

        public Developer(long empId, string name, string position)
        {
            this.empId = empId;
            this.name = name;
            this.position = position;
        }
        public void ShowEmployeeDetails()
        {
            Console.WriteLine($"{empId} {name} {position}");
        }
    }
}