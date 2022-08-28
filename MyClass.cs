using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP001Person
{
    internal class MyClass
    {


        public void CreatePerson()
        {
            Person person = new Person();

            GetName(person);

            GetDoB(person);

            GetEmail(person);

            GetPassword(person);

            Console.WriteLine($"Navn: {person.Name}\n" +
                $"Age: {person.Age}\n" +
                $"Email: {person.Email}\n" +
                $"Password: {person.Password}\n");

        }

        private void GetName(Person person)
        {
            do
            {
                Console.Write("Insert your name: ");
                person.Name = Console.ReadLine();
            }
            while (person.Name == null);
        }
        private void GetDoB(Person person)
        {
            do
            {
                Console.Write("Insert birthdate (dd/mm/yyyy): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime dt)) person.DoB = dt;
                
            }
            while (person.DoB == null);
        }
        private void GetEmail(Person person)
        {
            do
            {
                Console.Write("Insert email: ");
                var newEmail = Console.ReadLine();
                if (IsEmailValid(newEmail)) person.Email = newEmail;
                else Console.WriteLine("Email is not valid, please try again");
            }
            while (person.Email == null);
        }
        private void GetPassword(Person person)
        {
            do
            {
                Console.Write("Insert password: ");
                var newPassword = Console.ReadLine();
                if (IsPasswordValid(newPassword))
                {
                    person.Password = newPassword;
                }
                else
                {
                    Console.WriteLine("Password has to be both lowercase, " +
                        "uppercase, a number and more than 6 characters");
                }


            }
            while (person.Password == null);
        }

        //checking is password is valid
        public bool IsPasswordValid(string newPassword)
        {
            if (newPassword.Length > 6 &&
                newPassword.Any(char.IsUpper) &&
                newPassword.Any(char.IsLower) &&
                newPassword.Any(char.IsDigit) && 
                newPassword!=null) return true;
            else return false;
        }

        //checking email input
        public bool IsEmailValid(string newEmail)
        {
            if (newEmail.Contains("@") && newEmail.Contains(".")) return true;
            else return false;
        }
    }
}
