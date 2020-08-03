using System;
using System.Linq;

namespace AgeCalculation
{
    public class Age :File
    {
        public void SelectedOption(string input)
        {
            int choosedOption;
            Int32.TryParse(input, out choosedOption);

            switch (choosedOption)
            {
                case 1:
                    ViewAllPeople();
                    break;
                case 2:
                    Eldest();
                    break;
                case 3:
                    Youngest();
                    break;
                case 4:
                    AverageAge();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Podano niepoprawną wartość !");
                    break;
            }
            Console.ReadKey();
        }
        public void Youngest()
        {
            string[] youngestPerson=new string[3]{"","","1000"};
            foreach (var person in people)
            {
                if (person.Age < Convert.ToInt32(youngestPerson[2]))
                {
                    youngestPerson[0] = person.FirstName;
                    youngestPerson[1] = person.LastName;
                    youngestPerson[2] = Convert.ToString(person.Age);

                }
            }
            Console.WriteLine("Najmłodsza osoba to:");
            foreach (var person in youngestPerson)
            {
                Console.Write($"{person} ");
            }
            Console.Write("Lat");
        }

        public  void  Eldest()
        {
            string[] youngestPerson = new string[3] { "", "", "0" };
            foreach (var person in people)
            {
                if (person.Age > Convert.ToInt32(youngestPerson[2]))
                {
                    youngestPerson[0] = person.FirstName;
                    youngestPerson[1] = person.LastName;
                    youngestPerson[2] = Convert.ToString(person.Age);

                }
            }
            Console.WriteLine("Najstarsza osoba to:");
            foreach (var person in youngestPerson)
            {
                Console.Write($"{person} ");
            }
            Console.Write("Lat");
        }

        public void AverageAge()
        {
            double sumAverage=0;
            foreach (var person in people)
            {
                sumAverage = person.Age + sumAverage;
            }

            sumAverage = sumAverage / people.Count;
            Console.WriteLine($"Średni wiek wszystkich osób to {sumAverage} lat");
        }

        public void ViewAllPeople()
        {
            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");
            }
        }

    }
}
