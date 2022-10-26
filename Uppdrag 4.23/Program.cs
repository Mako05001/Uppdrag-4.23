Console.WriteLine("Skriv in ett heltal");

int tal = int.Parse(Console.ReadLine());
int st = tal; 

string svar = " ";
while (svar != "n")
{
    Console.WriteLine("Vill du skirva ett till tall eller inte (j/n)");
    svar = Console.ReadLine();
    if (svar == "n")
    {
        break;
    }
    Console.WriteLine("Skriv in ett heltal");
    int ntal = int.Parse(Console.ReadLine());

    if (ntal > st)
    {
        st = ntal;
    }

}
Console.WriteLine($"det här var det största talet som du skerv {st}");