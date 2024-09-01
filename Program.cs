Random rnd = new Random();
List<int> randomNumbers = Enumerable.Range(0,10).Select(r => rnd.Next()).ToList();

IEnumerable<int> evenNum = randomNumbers.Where(e => e % 2 == 0);
Console.WriteLine("Cift sayilar");
foreach(var e in evenNum)
{
    Console.WriteLine(e);
}
IEnumerable<int> oddNum = randomNumbers.Where(e => e % 2 != 0);
Console.WriteLine("Tek sayilar");
foreach (var e in oddNum) Console.WriteLine(e);
IEnumerable<int> pozitiveNum = randomNumbers.Where(e => e > 0);
Console.WriteLine("Pozitif sayilar");
foreach (var e in pozitiveNum) Console.WriteLine(e);
Console.WriteLine("Negatif sayilar");
IEnumerable<int> negativeNum = randomNumbers.Where(e => e < 0);
foreach (var e in negativeNum) Console.WriteLine(e);
Console.WriteLine("15'ten buyuk 22'den kucuk sayilar");
IEnumerable<int> between = randomNumbers.Where(e => e>15 && e<22);
foreach (var e in between) Console.WriteLine(e);
Console.WriteLine("Kareleri");
List<long> square = new List<long>();
foreach (var e in randomNumbers) square.Add(e*e);
foreach (var e in square) Console.WriteLine(e);
