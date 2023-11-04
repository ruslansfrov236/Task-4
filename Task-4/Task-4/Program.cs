

using System.Security.Cryptography.X509Certificates;
using Task_4;
using Task_4.customer;

int secim_et;
Console.Write(" Task sayina gore 1 ,2 ,3 ,4 olaraq secim et :");
secim_et = int.Parse(Console.ReadLine());
switch(secim_et){
    case 1:
        Person person = new Person();
        if (person != null)
        {

            person.İsAdult = false;
            Console.Write("Adinizi daxil edin:");
            person.Name = Console.ReadLine();
            Console.Write("Soyadinizi daxil edin:");
            person.SurName = Console.ReadLine();
            Console.Write("Yasinizi  daxil edin:");
            person.Age = byte.Parse(Console.ReadLine());
            if (person.Age >= 18)
            {
                person.İsAdult = true;
            }
            var isBool = person.İsAdult ? "Istifadeci 18  yasdan boyuk" : "Istifadeci 18  yasdan kicik";

            Console.Write($"Istifadeci adi ve soyadi :{person.Name} {person.SurName} \n" + $"Istifadeci yasi:{person.Age} \n" + $"{isBool}");
        }
        break;
     case 2:
        call();

        static void call()
        {
            Car car = new Car();



            car.Brend = "Ford";
            car.Model = "F-150";
            car.Color = "Blue";
            car.FuelType = "95";

            car.ModelYear = new DateTime(2017, 12, 15);



            Console.WriteLine($"\t\t\t\t\t\t Masin haqqinda melumat \t \n" + $" Masin brendi:{car.Brend}\n Masin Model:{car.Model}\n Yanacaq novu :{car.FuelType}\n Masin yaranma tarixi :{car.ModelYear}"
                );
        }
        break;

    case 3:
        MotoCycle moto = new MotoCycle();
        Console.Write("Moto brendi adini daxil edin :");
        moto.Brend = Console.ReadLine();
        Console.Write("Moto modelini adini daxil edin :");
        moto.Model = Console.ReadLine();
        Console.Write("Moto yanacaq novunu daxil edin :");
        moto.FuelType = Console.ReadLine();
        Console.Write("Moto  tam tarixi  daxil edin :");
        moto.ModelYear = DateTime.Parse(Console.ReadLine());
        Console.Write("Moto  suteti  daxil edin :");
        moto.Speed = byte.Parse(Console.ReadLine());

        moto.HasSidecar = false;
        if (moto.Speed >= 110)
        {
            moto.HasSidecar = true;
        }
        var sideCar = moto.HasSidecar ? "Suret oldurur" : "Bele davam edin";
        Console.WriteLine($"Moto brendin adi : {moto.Brend} \n" + $"Modelin adi:{moto.Model}\n" + $"Color:{moto.Color}\n" + $"Yanacaq novu:{moto.FuelType}\n" + $"Tarix:{moto.ModelYear}\n" + $"Suret heddi :{sideCar}");
        break;
    case 4:

        static bool isPasswordValid(Password password)
        {
            if (string.IsNullOrEmpty(password.PasswordValue) || password.PasswordValue.Length < 6 || !ContainsDigit(password.PasswordValue) || password.PasswordValue.Contains(password.Name))
            {
                return false;
            }

            return true;
        }

        static bool ContainsDigit(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }



        Password password = new Password();

        Console.Write("Adinizi daxil edin:");
        password.Name = Console.ReadLine();
        Console.Write("Password daxil edin:");
        password.PasswordValue = Console.ReadLine();

        if (!isPasswordValid(password))
        {
            Console.Write("Daxil olan sert uygun gelmir");
        }
        else
        {
            Console.Write($"Adiniz:{password.Name}\n Password:{password.PasswordValue}");
        }
        break;
    default:
        Console.Write("Daxil olan taski sayina gore 4 denedir");
        break;

}






















