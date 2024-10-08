



Console.WriteLine("Hur gammal är du?");

string answer = Console.ReadLine() ?? string.Empty;
int answer2;
int.TryParse(answer, out answer2);

bool entry = false;




while(entry != true)
{

if(answer2 >= 18) 
{
entry = true;
Console.WriteLine("Välkommen in till butiken!");

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
    
}




}





else if(answer2 < 18)
{
    entry = true;
    Console.WriteLine("Due för ung bror");
    
}



}

 





Console.ReadLine();






