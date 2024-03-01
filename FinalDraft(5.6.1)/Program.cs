using System;

namespace Module_5
{
    internal class Final_draft_5_6_1
    {
        static void Main(string[] args)
        {
            EnterUser(Anketa);
        }

        static void EnterUser(string Name, string LastName, int Age, int NumPet, int NumFavColor)
        {
            (string Name, string LastName, int Age, int NumPet, int NumFavColor) Anketa;

            Console.Write("Введите имя: ");
            Anketa.Name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            Anketa.LastName = Console.ReadLine();

            //string[] PetName
            //string[] favColor 

            string age;
            int intage;
            do
            {
                Console.Write("Введите возраст цифрами: ");
                age = Console.ReadLine();

            } while (Checknum(age, out intage));

            Anketa.Age = intage;

            Console.Write("Есть ли у вас питомцы? (Да/Нет): ");
            var HavePet = Console.ReadLine();

            if (HavePet == "да" || HavePet == "Да")
            {
                string pet;
                int intpet;
                do
                {
                    Console.WriteLine("Введите количество питомцев цифрами: ");
                    pet = Console.ReadLine();

                } while (Checknum(pet, out intpet));

                Anketa.NumPet = intpet;
            }

            string colors;
            int intcolors;
            do
            {
                Console.Write("Напишите количество ваших любимых цветов цифрами: ");
                colors = Console.ReadLine();
            } while (Checknum(colors, out intcolors));

            Anketa.NumFavColor = intcolors;
        }

        static bool Checknum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {

                if(intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            {
                corrnumber = 0;
                return true;
            }
        }
    }
}