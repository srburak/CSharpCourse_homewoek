
Customer customer1 = new Customer
{
    Id = 1,FirstName = "Engin",LastName = "Demiroğ",City = "Ankara"
};


Customer customer2 = new Customer (2,"Burak","Kaymaz","New York" );

Customer customer3 = new Customer();
customer3.Id = 3;
customer3.FirstName = "Salih";
customer3.LastName = "Demiroğ";
customer3.City = "İstanbul";

Console.WriteLine(customer2.FirstName);

class Customer
{
    public Customer()
    {
        
    }
    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}