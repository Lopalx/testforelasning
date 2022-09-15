

string[] bokTitlar = new string[4];

bokTitlar[0] = "Bok 1";
bokTitlar[1] = "Bok 2";
bokTitlar[2] = "Bok 3";
bokTitlar[3] = "Bok 4";

//var item in collection (för varje sak i samlingen)
//alternativt mot en for loop med i, enklare och smidigare
foreach (var bokTitel in bokTitlar)
{
    Console.WriteLine(bokTitel); //bokTitel kan vara vad som helst, så länge du ankallar samma namn
}

/*  //Detta är ett sätt att göra for loop med array (Length) for med i.
for (int i = 0; i < bokTitlar.Length; i++)
{

    Console.WriteLine("Bok nummer" + (i+1) + "är" + bokTitlar[i]);
}
*/


/*
//annan syntax, samma sak
string[] bokTitlar = new string[2] { "Bok1", "Bok2" };
*/

/*

int[] numbers = new int[3];

numbers[0] = 320;
numbers[1] = 440;
numbers[2] = 540;

Console.WriteLine($"Summan är {numbers[0] + numbers[1] + numbers[2] }");
*/


