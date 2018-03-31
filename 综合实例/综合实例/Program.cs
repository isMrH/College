using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 综合实例
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("xxx门禁系统:");
            Guest guest = new Guest("人猿泰山");
            guest.PressDoorbell();
            Console.WriteLine("你好，"+guest.Name+",欢迎你的来访！");
            Console.WriteLine("***********************************");
            Employee employee = new Employee("擎天柱");
            Console.WriteLine("本公司雇员请验证胸卡...");
            if (employee.IsEmployee == true)
            {
                Console.WriteLine("验证通过，" + employee.Name + "请进！");
            }
            else
            {
                Console.WriteLine("对不起，你不是本公司雇员！");
            }
            Console.WriteLine("***********************************");
            Admin admin = new Admin("犀利哥");
            Console.WriteLine("本公司雇员请验证胸卡...");
            if (admin.IsEmployee == true)
            {
                Console.WriteLine("验证通过，管理员请输入密码：");
                int pwd = int.Parse(Console.ReadLine());
                if (pwd == admin.Password)
                {
                    Console.WriteLine(admin.Name + ",欢迎你回来！");
                }
                else
                {
                    Console.WriteLine("密码输入错误，请重新输入！");
                }
            }
            else
            {
                Console.WriteLine("对不起，你不是本公司雇员！");
            }
            Console.ReadLine();
        }
    }
    class Guest
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Guest() { }
        public Guest(string n)
        {
            this.name = n;
        }
        public void PressDoorbell()
        {
            Console.WriteLine("你好，我是"+name+",来拜访贵公司。");
        }
    }
    class Employee : Guest
    {
        bool isEmployee;

        public bool IsEmployee
        {
            get { return isEmployee; }
            set { isEmployee = value; }
        }
        public Employee()
        {
            isEmployee = true;
        }
        public Employee(string n)
            : base(n)
        {
            isEmployee = true;
        }
    }
    class Admin : Employee
    {
        int password;

        public int Password
        {
            get { return password; }
            set { password = value; }
        }
        public Admin()
        {
            password = 123456;
        }
        public Admin(string n)
            : base(n)
        {
            password = 123456;
        }
    }
}
