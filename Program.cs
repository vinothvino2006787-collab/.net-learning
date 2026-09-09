using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 100;
            //double bigNum = num;
            //Console.WriteLine(bigNum);
            //Console.WriteLine("implicit casting");
            //Console.WriteLine("int value:" + num);
            //Console .WriteLine("covert double:"+bigNum);


            //double doublevalue = 123.456;
            //int intvalue =(int)doublevalue;
            //Console.WriteLine($"intvalue:{intvalue}");

            //string strNumber = "250";
            //int convertint = Convert.ToInt32(strNumber);
            //double covertDouble = Convert.ToDouble(strNumber);
            //Console.WriteLine(strNumber);


            //string strfloat = "12.34";
            //double parcedouble = double.Parse(strfloat);
            //Console.WriteLine(strfloat);
            //int num = 10;
            //if (num > 5)
            //{
            //    Console.WriteLine("num is greater than 5");
            //}
            //else
            //{
            //    Console.WriteLine("not a biger");
            //}

            //int marks = 45;
            //if (marks >= 90)
            //{
            //    Console.WriteLine("grade: A");
            //}
            //else if(marks>=80){
            //    Console.WriteLine("grade:B");

            //}
            //else if (marks >= 40)
            //{
            //    Console.WriteLine("grade:c");
            //}
            //else if (marks>= 35)
            //{
            //    Console.WriteLine("grade:d");
            //}
            //else
            //{
            //    Console.WriteLine("fail");
            //}
            //string[] fruits = { "apple", "banana", "cherry" };
            //foreach (String fruit in fruits)
            //{
            //    Console.WriteLine($"fruit:{fruit}");
            //}


            //for(int numloop = 1; numloop <= 10; numloop++)
            //{
            //    if(numloop == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(numloop);
            //}

            // Arithmetic operater


            //int a = 10;
            //int b = 5;

            //Console.WriteLine($"Addition:a+b={a+b}");
            //int a = 5;
            //int b = 12;
            //Console.WriteLine($"subraction:a-b={a - b}");

            //int a = 30;
            //int b = 40;
            //Console.WriteLine($"multiple:a*b={a * b}");


            //int a = 50;
            //int b = 40;
            //Console.WriteLine($"division:a/b={a/b}");


            //int a = 60;
            //int b = 40;
            //Console.WriteLine($"modules:a%b={a % b}/n");


            //int a = 70;
            //int b = 30;
            //Console.WriteLine($"a==b:{a==b}");
            //Console.WriteLine($"a!=b:{a != b}");
            //Console.WriteLine($"a>=b:{a>=b}");
            //Console.WriteLine($"a<=b:{a <= b}");


            //LogicalCallContext operater

            //bool x =true, y = false;

            //Console.WriteLine($"x && y : {x && y}");
            //Console.WriteLine($"x || y : {x || y}"); 
            //Console.WriteLine($"!x     : {!x}");



            //Unary operater

            //int a = 10;

            //Console.WriteLine($"++a={++a}");
            //Console.WriteLine($"--a={--a}");
            //Console.WriteLine(-a);


            //ternory operater
            //int age = 25;
            //string result = (age >= 18) ? "Eligible to vote" : "Not eligible";
            //Console.WriteLine($"Age = {age}:{result}");

            //type casting


            //double a= 100.76;
            //int b = (int)a;
            //Console.WriteLine(b);

            //string a = "35.98";
            //double b = Convert.ToDouble(a);
            //Console.WriteLine(b);

            //int a = 100;
            //string b = Convert.ToString(a);
            //Console.WriteLine(b);


            //string a = "1567";
            //int b =Convert.ToInt32(a);
            //Console.WriteLine(b);

            //loops

            //Even numbers

            //for (int i = 2; i <= 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //Odd numbers

            //for(int i = 1; i <= 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //int sum = 0;
            //for(int i = 1; i <= 10; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine(sum);


            string[] names = { "vinoth", "prasanth", "shelton", "santhos", "ravi" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
