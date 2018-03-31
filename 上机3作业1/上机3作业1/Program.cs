using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 上机3作业1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Jiben = 1000;
            emp.ComputeSalary();
            emp.ComputeSalary(210);
            emp.ComputeSalary(210,490);
            Console.ReadLine();
        }
    }
    class Employee
    {
        private int jiben;

        public int Jiben
        {
            get { return jiben; }
            set { jiben = value; }
        }
        public void ComputeSalary()
        {
            Console.WriteLine("员工的收入是{0}元", jiben);
        }
        public void ComputeSalary(int HRA)
        {
            Console.WriteLine("员工的收入是{0}元", jiben + HRA);
        }
        public void ComputeSalary(int HRA, int jiangjin)
        {
            Console.WriteLine("员工的收入是{0}元", jiben + HRA + jiangjin);
        }

    }
}
