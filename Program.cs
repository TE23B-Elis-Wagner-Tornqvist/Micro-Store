



using System.Runtime;

Console.WriteLine("Hur gammal är du?");

string answer = Console.ReadLine() ?? string.Empty;
int answer2;
int.TryParse(answer, out answer2);

bool entry = false;
int money = 200;
int shotgunPrice = 20;
int klubbaPrice = 1;
int hundPrice = 100;

int sa = 0;
int klubbor = 0;
int hundar = 0;

while(entry != true)
{

if(answer2 >= 18) 
{
entry = true;


Console.WriteLine("Välkommen in till butiken!");
while(money > 0 )
{



Console.WriteLine($"Du har {sa} shotguns, {klubbor} klubbor och {hundar} hundar");

Console.WriteLine($"Du har {money} pengar");
Console.WriteLine("Här är våra saker du kan köpa:");
Console.WriteLine("Shotgun: 20kr");
Console.WriteLine("Klubba: 1kr");
Console.WriteLine("Hund: 100Kr");

Console.WriteLine("Vad skulle du vilja köpa?");

string buy = Console.ReadLine() ?? string.Empty;

if(buy.ToLower() == "shotgun")
{
    Console.Clear();
    Console.WriteLine("Bra val! Hur många skulle du vilja ha?");
    string amountText = Console.ReadLine() ?? string.Empty;
    int amount;
    int.TryParse(amountText, out amount);
    
    shotgunPrice *= amount;
    money -= shotgunPrice;
 
  if(money  > 0) 
  {
    Console.WriteLine($"Bra val, du köpte {amount} shotguns");
    sa += amount;
  } 

     if (money < 0)
{
    Console.WriteLine("Du har int råd med det där");
    money = 200;
}
  
}



else if(buy.ToLower() == "klubba")
{
    Console.Clear();
    Console.WriteLine("Bra val! Hur många skulle du vilja ha?");
    string amountText = Console.ReadLine() ?? string.Empty;
    int amount;
    int.TryParse(amountText, out amount);
    
    klubbaPrice *= amount;
    money -= klubbaPrice;
 
  if(money  > 0) 
  {
    Console.WriteLine($"Bra val, du köpte {amount} klubbor");
    klubbor += amount;
  } 

   if (money < 0)
{
    Console.WriteLine("Du har int råd med det där");
    money = 200;
}

}

else if(buy.ToLower() == "hund")
{
    Console.Clear();
    Console.WriteLine("Bra val! Hur många skulle du vilja ha?");
    string amountText = Console.ReadLine() ?? string.Empty;
    int amount;
    int.TryParse(amountText, out amount);
    
    hundPrice *= amount;
    money -= hundPrice;
 
  if(money  > 0) 
  {
    Console.WriteLine($"Bra val, du köpte {amount} hundar");
    hundar += amount;
  } 

   if (money < 0)
{
    Console.WriteLine("Du har int råd med det där");
    money = 200;
}


}

}

}



else if(answer2 < 18)
{
    entry = true;
    Console.WriteLine("Due för ung bror");
    
}



}

 





Console.ReadLine();






