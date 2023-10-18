using Newtonsoft.Json;
using System;

int a = 0;

stuff a1 = new stuff(10, "a", 15.5, 10.1, true);
stuff a2 = new stuff(10, "b", 15.5, 10.1, true);
stuff a3 = new stuff(10, "c", 15.5, 10.1, true);
stuff a4 = new stuff(10, "d", 15.5, 10.1, true);
stuff a5 = new stuff(10, "e", 15.5, 10.1, true);
stuff a6 = new stuff(10, "f", 15.5, 10.1, true);
stuff a7 = new stuff(10, "z", 15.5, 10.1, true);
stuff a8 = new stuff(10, "x", 15.5, 10.1, true);
stuff a9 = new stuff(10, "c", 15.5, 10.1, true);
stuff a10 = new stuff(10, "q", 15.5, 10.1, true);

List<stuff> stuffs = new List<stuff>();
stuffs.Add(a1);
stuffs.Add(a2);
stuffs.Add(a3);
stuffs.Add(a4);
stuffs.Add(a5);
stuffs.Add(a6);
stuffs.Add(a7);
stuffs.Add(a8);
stuffs.Add(a9);
stuffs.Add(a10);

foreach (stuff c in stuffs)
{
    string json = JsonConvert.SerializeObject(c);
    Console.WriteLine(json);
}

Console.WriteLine("Enter 1");
a = Convert.ToInt32(Console.ReadLine());
switch(a)
{
    case 1:
        foreach (stuff c in stuffs)
        {
            string json = JsonConvert.SerializeObject(c);
            Console.WriteLine(json);
        }
        break;
}


class stuff
{
    public int price;
    public string name;
    public double weight;
    public double scope;
    public bool fragility;

    public stuff(int price, string name, double weight, double scope, bool fragility)
    {
        this.price = price;
        this.name = name;
        this.weight = weight;
        this.scope = scope;
        this.fragility = fragility;
    }
}




