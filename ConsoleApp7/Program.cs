using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vehicle exercise
            var car = new Car("Toyota", 2022, 4);
            var bus = new Bus("Mercedes", 2020, 50);
            var bike = new Motorcycle("Honda", 2023, false);

            car.Show(); car.Start();
            bus.Show(); bus.Start();
            bike.Show(); bike.Start();

            Console.WriteLine();

            // University members exercise
            Console.WriteLine("Student:");
            var student = new Student("Sara", "sara@mail.com", "S123", 3.8);
            student.DisplayBasicInfo();
            student.DisplayStudent();

            Console.WriteLine();
            Console.WriteLine("Teacher:");
            var teacher = new Teacher("Omar", "omar@mail.com", "E456", 8500, "C#");
            teacher.DisplayBasicInfo();
            teacher.DisplayEmployee();
            teacher.Teach();
        }
    }

    // Vehicle hierarchy
    class Vehicle
    {
        protected string Brand { get; }
        protected int Year { get; }

        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        public void Start() => Console.WriteLine($"{Brand} is starting");
    }

    class Car : Vehicle
    {
        private int Doors { get; }
        public Car(string brand, int year, int doors) : base(brand, year) => Doors = doors;
        public void Show() => Console.WriteLine($"Car doors: {Doors}");
    }

    class Bus : Vehicle
    {
        private int Capacity { get; }
        public Bus(string brand, int year, int capacity) : base(brand, year) => Capacity = capacity;
        public void Show() => Console.WriteLine($"Bus capacity: {Capacity}");
    }

    class Motorcycle : Vehicle
    {
        private bool HasSidecar { get; }
        public Motorcycle(string brand, int year, bool hasSidecar) : base(brand, year) => HasSidecar = hasSidecar;
        public void Show() => Console.WriteLine($"Has sidecar: {(HasSidecar ? "Yes" : "No")}");
    }

    // University members
    class Person
    {
        protected string Name { get; }
        protected string Email { get; }

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
            Console.WriteLine("Person constructor");
        }

        public void DisplayBasicInfo() => Console.WriteLine($"{Name} - {Email}");
    }

    class Student : Person
    {
        private string StudentId { get; }
        private double Gpa { get; }

        public Student(string name, string email, string id, double gpa) : base(name, email)
        {
            StudentId = id;
            Gpa = gpa;
            Console.WriteLine("Student constructor");
        }

        public void DisplayStudent() => Console.WriteLine($"{StudentId} - GPA: {Gpa}");
    }

    class Employee : Person
    {
        protected string EmployeeId { get; }
        protected double Salary { get; }

        public Employee(string name, string email, string id, double salary) : base(name, email)
        {
            EmployeeId = id;
            Salary = salary;
            Console.WriteLine("Employee constructor");
        }

        public void DisplayEmployee() => Console.WriteLine($"{EmployeeId} - Salary: {Salary}");
    }

    class Teacher : Employee
    {
        private string CourseName { get; }

        public Teacher(string name, string email, string id, double salary, string course) : base(name, email, id, salary)
        {
            CourseName = course;
            Console.WriteLine("Teacher constructor");
        }

        public void Teach() => Console.WriteLine($"Teaching: {CourseName}");
    }
}
