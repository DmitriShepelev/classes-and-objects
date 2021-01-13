using System;

namespace ClassesAndObjectsTask
{
    public class Employee
    {
        private readonly string surname;
        private readonly int age;

        public Employee()
        {
            this.surname = string.Empty;
            this.age = 0;
        }

        public Employee(string surname, int age)
        {
            this.surname = surname ?? throw new ArgumentException($"{nameof(surname)} can not be null");
            this.age = age;
        }

        public void SetSurname(string value)
        {
            _ = new Employee(value, this.age);
        }

        public string EmployeeInfo()
        {
            return $"Surname: {this.surname}, Age: {this.GetEmployeeAge()}";
        }

        private string GetEmployeeAge()
        {
            return this.age.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
