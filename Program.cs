using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
     class student
    {
        string name;
        int age;

     public student(string n,int a)
        {

            name = n;
            age = a;
        }
        public void display()
        {
            Console.WriteLine("name:"+name);
            Console.WriteLine("age:" + age);

        }
        static void Main(string[] args)
        {
            student s1 = new student("vinoth", 20);
            s1.display();
        }
    }
}
