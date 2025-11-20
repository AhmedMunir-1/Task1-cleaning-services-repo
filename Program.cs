// See https://aka.ms/new-console-template for more information

//cleaning services
Dictionary<string,double> carpetPrice = new Dictionary<string, double>() {{"small",25}, {"large",35},{"Taxes",0.06},{"estimatValid",30}};

Console.WriteLine("========================");

Console.Write("Please enter Num of Small Carbets : ");
int SmallCarbetNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter Num of Large Carbets : ");
int LargeCarpetNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Price per small carpets: $25");
Console.WriteLine($"Price per large carpets: $35");

double totalCost = (SmallCarbetNum*carpetPrice["small"])+(LargeCarpetNum*carpetPrice["large"]);
Console.WriteLine($"Cost : {totalCost:F2}");

double totalTaxes = totalCost*carpetPrice["Taxes"];
Console.WriteLine($"Tax : {totalTaxes:F2}");

Console.WriteLine("========================");

Console.WriteLine($"Total estimate: {totalCost+totalTaxes:F2}");
Console.WriteLine($"This estimate is valid for {carpetPrice["estimatValid"]}");