Console.WriteLine("Hej verden, dette er min git øvelse");
Console.ReadLine();

Console.WriteLine("Tryk på en tast for at afslutte...");
Console.ReadLine();

Console.WriteLine("Hej, jeg skal lave et par flere commits");
Console.WriteLine("Hola, dette er en commit til min branch");
Console.ReadLine();

Console.WriteLine("Hvad er dit navn: ");
string navn = Console.ReadLine();
Console.WriteLine("Hej " + navn + ", nice to meet you!");
// Grundet til at lave branches, er at teste ændiringer uden at ødelægge master branchen.
// Fordelen ved dette er at teste nye ting, som kan være farlige for master branchen, og derfor kan man teste i sine branches 