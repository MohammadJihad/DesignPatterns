namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Creational Patterns
            #region Singleton Pattern
            //Singleton singleton = Singleton.Instance;
            #endregion

            #region Factory Method Pattern
            //Console.WriteLine("------Factory Method Pattern------");
            //ICreditCard creditCard = new PlatinumFactory().CreateProduct();
            //if (creditCard != null)
            //{
            //    Console.WriteLine("Card Type : " + creditCard.GetCardType());
            //    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
            //    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            //}
            //else
            //{
            //    Console.Write("Invalid Card Type");
            //}
            //Console.WriteLine("--------------");
            //creditCard = new MoneyBackFactory().CreateProduct();
            //if (creditCard != null)
            //{
            //    Console.WriteLine("Card Type : " + creditCard.GetCardType());
            //    Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
            //    Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            //}
            //else
            //{
            //    Console.Write("Invalid Card Type");
            //}
            //Console.ReadLine();
            #endregion

            #region Abstract Factory Pattern
            //Console.WriteLine("------Abstract Factory Pattern------");
            //IAnimal animal = null;
            //AnimalFactory animalFactory = null;
            //string speakSound = string.Empty;
            //// Create the Sea Factory object by passing the factory type as Sea
            //animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            //Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            //Console.WriteLine();
            //// Get Octopus Animal object by passing the animal type as Octopus
            //animal = animalFactory.GetAnimal("Octopus");
            //Console.WriteLine("Animal Type : " + animal.GetType().Name);
            //speakSound = animal.Speak();
            //Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            //// Create Land Factory object by passing the factory type as Land
            //animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            //Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            //Console.WriteLine();
            //// Get Lion Animal object by passing the animal type as Lion
            //animal = animalFactory.GetAnimal("Lion");
            //Console.WriteLine("Animal Type : " + animal.GetType().Name);
            //speakSound = animal.Speak();
            //Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            //Console.WriteLine();
            //// Get Cat Animal object by passing the animal type as Cat
            //animal = animalFactory.GetAnimal("Cat");
            //Console.WriteLine("Animal Type : " + animal.GetType().Name);
            //speakSound = animal.Speak();
            //Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            //Console.Read();
            #endregion
            #endregion

            #region Structural Patterns
            #region Adapter Pattern
            //Console.WriteLine("------Adapter Pattern------");

            //Console.WriteLine("------Example (1) ------");
            //Person p = new Person();
            //p.SwitchOn(new HP_Laptop()); //On HP Laptop  
            //p.SwitchOn(new Compaq_Laptop()); //On Compaq laptop   


            //Console.WriteLine("------Example (2) ------");
            //ITarget adapter = new VendorAdapter();
            //foreach (string product in adapter.GetProducts())
            //{
            //    Console.WriteLine(product);
            //}
            //Console.ReadLine();
            #endregion
            #endregion

            #region Behavioral Patterns
            #region Strategy Pattern
            //Console.WriteLine("------Strategy Pattern------");
            //List<Employee> employees = new List<Employee>();
            //employees.Add(new Employee()
            //{
            //    Name = "Mohammad Helal",
            //    Type = EmployeeType.PartTime
            //});
            //employees.Add(new Employee()
            //{
            //    Name = "Mohammad Adnan",
            //    Type = EmployeeType.FullTime
            //});

            //var manager = new SalaryManager();
            //foreach (var item in employees)
            //{
            //    Console.WriteLine($"Name: {item.Name} - Salary: {manager.CalculateSalary(item)}");
            //}
            //Console.ReadLine();
            #endregion

            #region State Pattern
            //Console.WriteLine("------State Pattern------");
            //CDPlayer cdPlayer = new CDPlayer();
            ////Change CD Player state from 'Closed' to 'Opened'
            //cdPlayer.Press();

            ////Change CD Player state from 'Opened' to 'Playing'
            //cdPlayer.Press();

            ////Change CD Player state from 'Playing' to 'Closed'
            //cdPlayer.Press();

            //Console.ReadLine();
            #endregion 
            #endregion
        }
    }
}
