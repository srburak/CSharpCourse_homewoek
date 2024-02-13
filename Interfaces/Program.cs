
// Interface'ler new'lenemezler
//IPersonManager customerManager = new CustomerManager();

//IPersonManager employeeManager = new EmployeeManager();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(new InternManager());

interface IPersonManager
{
    void Add();
    void Update();
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        //Müşteri ekleme kodları
        Console.WriteLine("Müşteri eklendi");
    }

    public void Update()
    {
        //Müşteri güncelleme kodları
        Console.WriteLine("Müşteri güncellendi");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        //Personel ekleme kodları
        Console.WriteLine("Personel eklendi");
    }

    public void Update()
    {
        //Personel güncelleme kodları
        Console.WriteLine("Personel güncellendi");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        //Stajyer ekleme kodları
        Console.WriteLine("Stajyer eklendi");
    }

    public void Update()
    {
        //Stajyer güncelleme kodları
        Console.WriteLine("Stajyer güncellendi");
    }

}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}