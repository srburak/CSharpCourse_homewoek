
//int sayi1 = 10;
//int sayi2 = 20;
//sayi1 = sayi2;
//sayi2 = 100;
//Console.WriteLine("Sayı 1: " + sayi1);

//// array, class, interface referans tiplerdir
//int[] sayilar1 = new int[] { 1, 2, 3 };
//int[] sayilar2 = new int[] { 10, 20, 30 };
//sayilar1 = sayilar2;
//sayilar2[0] = 1000;
//Console.WriteLine("Sayılar 1[0]: " + sayilar1[0]);

Person person1 = new Person();
Person person2 = new Person();
person1.FirstName = "Engin";

person2 = person1;
person1.FirstName = "Derin";
//Console.WriteLine(person2.FirstName);


Customer customer1 = new Customer();
customer1.FirstName = "Salih";
customer1.CreditCardNumber = "1234567890";

Employee employee1 = new Employee();
employee1.FirstName = "Veli";

Person person3 = customer1;
customer1.FirstName = "Ahmet";

//Console.WriteLine(((Customer)person3).CreditCardNumber);

PersonManager personManager = new PersonManager();
personManager.Add(customer1);

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string CreditCardNumber { get; set; }
}

class Employee : Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
}