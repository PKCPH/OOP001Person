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



        }

        private void GetName(Person person)
        {
            do
            {
                Console.Write("Indtast navn: ");
                person.Name = Console.ReadLine();
            }
            while (person.Name == null);
        }
        private void GetDoB(Person person)
        {
            do
            {
                Console.Write("Indtast fødselsdato (dd/mm/åååå: ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime dt)) person.DoB = dt;
                else person.DoB = null;
            }
            while (person.DoB == null);
        }
        private void GetEmail(Person person)
        {
            do
            {
                Console.Write("Indtast email: ");
                person.Email = Console.ReadLine();
            }
            while (person.Email == null);
        }
        private void GetPassword(Person person)
        {
            do
            {
                Console.Write("Indtast password: ");
                person.Password = Console.ReadLine();
            }
            while (person.Password == null);
        }

        ///////Fields///////////
        public string Name { get; set; }


        ///////Properties///////////
        public int Age { get; set; }



        ///////Constructors///////////
        public MyClass()
        {
            MyMethod();
        }

        public MyClass(string name)
        {
            this.Name = name;
            MyMethod();
        }


        ///////Methods///////////
        public void MyMethod()
        {
            Console.WriteLine("This is our string" + Name);
        }
    }
}
