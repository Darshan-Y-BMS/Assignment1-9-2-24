﻿using System;
using System.Diagnostics;
using System.Security.Claims;
using System.Security.Principal;
namespace Siemen
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    //Exercise 1: Creating a Class
    //Create a Car class with the following attributes:
    // make(string)
    // model(string)
    // year(integer)
    // mileage(float)
    //Include a method called display_info that prints out the car&#39;s information in a user-
    //friendly format.
    //Exercise 2: Object Instances
    //Create two instances of the Car class from Exercise 1 and set different values for their
    //attributes. Then, call the display_info method for each car
    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public class Car// car class
    {
        private string make;// Company that manufactured the car
        private string model;// Model of car
        private int year;// The year in which car is manufactured
        private float mileage;//Mileage of car
   
        //Constructer
        public Car(string make,string model,int year,float mileage)
        {
            this.make    = make;
            this.model   = model;
            this.year    = year;
            this.mileage = mileage;
        }


        public void  GetCarDetails()
        {
            // getting details of car manually from user
            Console.WriteLine("Enter the car details ");
            Console.Write("Make  :");
            make = Console.ReadLine();
            Console.Write("Model :");
            model  = Console.ReadLine();
            Console.Write("Year :");
            year   = int.Parse(Console.ReadLine());
            Console.Write("Milage :");
            mileage = float.Parse(Console.ReadLine());
        }
        
        public void display_info()
           // printing the car details
        {
            Console.WriteLine("\n\n\tCAR INFORMATIONS");
            Console.WriteLine("\tMaking   :"+ make);
            Console.WriteLine("\tModel    :"+ model);
            Console.WriteLine("\tYear     :"+ year);
            Console.WriteLine("\tMilage   :"+ mileage+"Kmpl");
        }
    }

   ///////////////////////////////////////////////////////////////////////////////////////////////////
   //Exercise 3: Bank Account Class
   //Create a BankAccount class with the following attributes and methods:
   //Attributes:
   //account_number(string)
   //account_holder(string)
   //balance(float) 
   //Methods:
   //display_account_info: prints out the account number, account holder, and
   //balance.
   //deposit: accepts an amount and adds it to the balance.
   //withdraw: accepts an amount and subtracts it from the balance.
    public class Bank
    {
        private string account_number;
        private string account_holder;
        private float balance;

        public Bank(string acc_num,string acc_hold,float bal)
        {
            this.account_number  = acc_num;
            this.account_holder  = acc_hold;
            this.balance = bal;
        }
        public void display_account_info()
        {
            Console.WriteLine("BANK DETAILS :");
            Console.WriteLine("Account holder :" + this.account_holder);
            Console.WriteLine("Account number :" + this.account_number);
            Console.WriteLine("Balance        :" + this.balance);
        }   
        public void show_balance()
        {
            Console.WriteLine("Current balance is " + this.balance +" Rupees");
        }
        public void deposit(float amount)
        {
            this.balance += amount;
            show_balance();
        }
        public void withdraw(float amount)
        {
            this.balance -= amount;
            show_balance();
        }
    }
    /// <summary>
    //Exercise 4: Book Class
    // Create a Book class with the following attributes:
    // title(string)
    // author(string)
    // publication_year(integer)
    // genre(string)
    //Include a method called get_summary that prints out a summary of the book, including
    //all its attributes.
    /// </summary>
    public class Book
    {
        private string title;
        private string author;
        private string genre;
        private int publication_year;

        public Book(string title,string author,string genre,int publication_year)
        {
            this.title = title; 
            this.author = author;
            this.genre = genre; 
            this.publication_year= publication_year;
        }
        public void get_summary()
        {
            Console.WriteLine($"\n{title} is {genre} book written by {author}, \n" +
                $"published in the year {publication_year}\n\n");
        }
    }
    //Exercise 5: Employee Class
   //Create an Employee class with the following attributes:
   // name(string)
   // employee_id(integer)
   // position(string)
   // salary(float)
   //Include a method called get_salary_details that prints out the employee&#39;s name,
   //employee ID, position, and salary.
   public class Employee
    {
        private string name;
        private string position;
        private int employee_id;
        private float salary;

        public Employee( string name,string position,int employee_id , float salary)
        {
            this.name = name;
            this.position = position;
            this.employee_id = employee_id;
            this.salary = salary;
        }
        public void get_salary_details()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("Name        : " + this.name);
            Console.WriteLine("Employee ID : " + this.employee_id);
            Console.WriteLine("Position    : " + this.position);
            Console.WriteLine("Salary      : " + this.salary + " Rupees per annum");
        }

    }

   //Exercise 6: Rectangle Class
   //Create a Rectangle class with the following attributes:
   // width(float)
   // height(float)
   //Include methods to calculate and return the area and perimeter of the rectangle.

   class Rectangle
    {
        public float width,height;
        
        public Rectangle(float width,float height) 
        { 
            
            this.width = Math.Abs(width);
            this.height =Math.Abs(height);
            Console.WriteLine($"Width    : {this.width} units \nHeight   : {this.height} units");
        }
       
        public float GetArea() 
        {
            return width*height;
        }

        public float GetPerimeter()
        {
            return (width+height)*2;
        }
    }
    internal class Program
    {
        void Excercise1()
        {
            Car car = new Car("Tata", "SUV", 2019, 112);
            car.display_info();
        }
        void Excercise2()
        {
            Car car1 = new Car("Tata", "Nano", 2015, 89);
            Car car2 = new Car("Mahindra", "Z+", 2019, 95);
            car1.display_info();
            car2.display_info();
        }
        void Excercise3()
        {
            Bank acc_holder = new Bank("1025684222", "Raghava", 294566);
            acc_holder.display_account_info();
            Console.WriteLine("\n\nEnter 1 to withdraw \nEnter 2 to deposit \nAny number to exit");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter the amount");
                float amount = float.Parse(Console.ReadLine());
                acc_holder.withdraw(amount);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the amount");
                float amount = float.Parse(Console.ReadLine());
                acc_holder.deposit(amount);
            }
            else { Console.WriteLine("Invalid input !!");
            }

        }
        void Excercise4()
        {
            Book book = new Book("The wonder of space", "K C Chandrashekar", "Science fiction", 2007);
            book.get_summary();

        }
        void Excercise5()
        {
            Employee emp = new Employee("Pruthiraj", "Product Developer", 2002332, 500000);
            emp.get_salary_details();

        }
        void Excercise6()
        {
            Rectangle rectangle = new Rectangle(24, -30);
            Console.WriteLine("Area of rectangle is       : " + rectangle.GetArea() + " squints");
            Console.WriteLine("Perimeter of rectangle is  : " + rectangle.GetPerimeter() + " squnits");
        }
        void CheckPolarity(float num)
        {
            //Exercise 7: If-Else Statements
            //Write a program that checks if a given number is positive, negative, or zero.
            if (num == 0)
            {
                Console.WriteLine(num + " is zero");
            }
            else if (num < 0)
            {
                Console.WriteLine(num + " is negetive");
            }
            else
            {
                Console.WriteLine(num + " is positive");
            }

        }
        void SumOfNumbers()
        {
            //Exercise 8: For Loop
            //Write a program that calculates the sum of all numbers from 1 to 10 using a for loop.
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of all numbers from 1 to 10 is " + sum);

        }
        void WhileLoop()
        {
            //Exercise 9: While Loop
            //Write a program that prints Fibonacci series up to a specified limit using a while loop.            
            int num = 10; //num represents till how many number fibonacci must be printed
            int temp1 = 0;//temporary variable  1
            int temp2 = 1;//temporary variable  2
            int temp3 = 1;//temporary variable  3
            num = num - 2;
            Console.WriteLine($"First {num} Fibonacci numbers are :-");
            Console.Write(" 0 1");
            while (num-- > 0)
            {
                Console.Write(" "+ (temp1+temp2));
                temp3 = temp2;
                temp2 = temp1 + temp3;
                temp1 = temp3;
            }Console.WriteLine("\n\n");

        }
        void Grade()
        {
            //Exercise 10: Grade Classification
            //Write a program that takes a student's grade as input and uses a switch statement to
            //determine and display the corresponding grade classification(A, B, C, D, or F).

            char grade;
            Console.WriteLine("Please enter your grade :");
            grade = Char.Parse(Console.ReadLine().ToUpper());
            
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("You passed in distinction with A grade ");
                    break;
                case 'B':
                    Console.WriteLine("You passed in first class with B grade ");
                    break;
                case 'C':
                    Console.WriteLine("You passed in second class with C grade ");
                    break;
                case 'D':
                    Console.WriteLine("You passed in third class with D grade ");
                    break;
                case 'F':
                    Console.WriteLine("You are failed , Better luck next time ");
                    break;
                default:
                    Console.WriteLine("Invalid input !");
                    break;

            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            // object created to call excercise (mathods) in class Program
            //p.Excercise1();
            //p.Excercise2();
            //p.Excercise3();
            //p.Excercise4();
            //p.Excercise5();
            //p.Excercise6();
            //p.CheckPolarity(-3434);
            //p.SumOfNumbers();
            //p.WhileLoop();
            //p.Grade();
            // remove comment on resepective programme to call
        }
    }
}
