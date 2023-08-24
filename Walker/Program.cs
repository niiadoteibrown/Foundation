// See https://aka.ms/new-console-template for more information

using Walker;

Console.WriteLine("Hello, World!");
Console.WriteLine("Temperature on {0:D} is {1}", DateTime.Today, 23.4);

var height = 1.88D;
Console.WriteLine($"The variable {nameof(height)} has value {height}");

var price = 4.99M;

HttpClient client = new();
HttpResponseMessage response = await client.GetAsync("");

Animal?[] animals = new Animal?[]
{
    new Cat { Name = "Karen", Born = new(year: 2022, month: 8, day: 23), Legs = 4, IsDomestic = true },
    null,
    new Cat { Name = "Mufasa", Born = new(year: 1994, month: 6, day: 12) },
    new Spider { Name = "Sid Vicious", Born = DateTime.Today, IsPoisonous = true },
    new Spider { Name = "Captain Furry", Born = DateTime.Today }
};

foreach (Animal? animal in animals)
{
    string message;

    switch (animal)
    {
        case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
            message = $"The cat named {fourLeggedCat.Name} has four legs.";
            break;
        case Cat wildCat when wildCat.IsDomestic == false:
            message = $"The non-domestic cat is called {wildCat.Name}.";
            break;
        case Cat cat:
            message = $"The cat is named {cat.Name}";
            break;
        default:
            message = $"The animal named {animal.Name} is a {animal.GetType().Name}.";
            break;
        case Spider spider when spider.IsPoisonous:
            message = $"The {spider.Name} spider is poisonous. Run!";
            break;
        case null:
            message = "The animal is null";
            break;
    }
    
    Console.WriteLine($"Switch statement: {message}");
}
