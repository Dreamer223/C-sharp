Car[] cars =
{
    new Car("Ferrari", 198, 340, 458),
    new Car("Porshe", 200, 319, 420)
};

for (int i = 0; i < cars.Length; i++)
{
    System.Console.WriteLine((i + 1) + " ");
    cars[i].ShowInfo();
}


class Car
{
    public string name;
    public int speed;
    public int maxSpeed;
    public int horsePower;

    public Car(string Name, int Speed, int MaxSpeed, int HorsePower)
    {
        name = Name;
        speed = Speed;
        maxSpeed = MaxSpeed;
        horsePower = HorsePower;

    }

    public void ShowInfo()
    {
        System.Console.WriteLine($"Название машины: {name}\n Средняя скорость: {speed}\n Максимальная скорость: {maxSpeed}\n Лошадиные силы: {horsePower}");
    }
}

