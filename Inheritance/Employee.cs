﻿using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Employee
    {
        int empId;
        string name;
        string department;

        static void Main(string[] args)
        {
            Employee emp1 = new Employee(100, "Hey You", "Call Center");
            Manager mgr1 = new Manager(10, "Mr Smith", "IT", 10000);
            CEO ceo1 = new CEO(1, "Madam", "Executive", 100000, "Row 1 Slot 1");
        }

        static void PrintEmpDetails(Employee emp)
        {
            Console.WriteLine($"{emp.Name} works in dept {emp.Department} ID: {emp.empId}");
        }

        public override string ToString()
        {
            return String.Format($"{EmpId}: {Name} works in department {Department}");
        }

        public Employee(int empId, string name, string department)
        {
            this.EmpId = empId;
            this.Name = name;
            this.Department = department;
        }

        public int EmpId { get => empId; set => empId = value; }
        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
    }

    class Manager : Employee
    {
        decimal signingLimit;
        List<Employee> employees;

        public override string ToString()
        {
            return base.ToString() + $"\n\tSigning Limit: {signingLimit}";
        }

        public Manager(int empId, string name, string department, decimal signingLimit)
                                        : base(empId, name, department)
        {
            this.SigningLimit = signingLimit;
            Employees = new List<Employee>();
        }

        public void Add(Employee emp)
        {
            Employees.Add(emp);
        }
        public decimal SigningLimit { get => signingLimit; set => signingLimit = value; }
        internal List<Employee> Employees { get => employees; set => employees = value; }
    }

    class CEO : Manager
    {
        string parkingSpot;

        public override string ToString()
        {
            return base.ToString() + $"\n\t\tParking Spot: {parkingSpot}";
        }

        public CEO(int empId, string name, string department, decimal signingLimit, string parkingSpot)
                        : base(empId, name, department, signingLimit)
        {
            this.ParkingSpot = parkingSpot;
        }
        public string ParkingSpot { get => parkingSpot; set => parkingSpot = value; }
    }
}
