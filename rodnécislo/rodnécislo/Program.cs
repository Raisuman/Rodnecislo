// See https://aka.ms/new-console-template for more information
using rodnécislo.Funkce;


char[] letters;
string[] line;

do
{
    Console.Clear();
    Console.WriteLine("Zadej Rodné číslo:");

    letters = Console.ReadLine().ToCharArray();
} while (letters.Length == 0);

if (letters.Length == 11)
{
    letters[6] = '/';
    string s = new string(letters);
    line = s.Split('/');

    bool checkRok = int.TryParse(line[0].Substring(0, 2), out int rok);
    bool checkMesic = int.TryParse(line[0].Substring(2, 2), out int mesic);
    bool checkDen = int.TryParse(line[0].Substring(4, 2), out int den);

    if ((checkRok == true) && (checkMesic == true) && (checkDen == true))
    {
        rok = kontrolaRok.uRok(rok);
        if(rok == 0)
        {
            Console.WriteLine("Chyba zadaní roku");
        }
        mesic = kontrolaMesic.uMesic(mesic);
        if (mesic == 0)
        {
            Console.WriteLine("Chyba zadaní měsíce");
        }
        den = kontrolDen.kontrolaDen(den, mesic, rok);
        if (den == 0)
        {
            Console.WriteLine("Chyba zadaní dne");
        }
        if ((mesic != 0) && (den != 0) && (rok != 0))
        {
            kontrola.kontrolaRcislo(line);

            int vek = DateTime.Today.Year - rok;
            Console.WriteLine("Den: " + den + " měsíc: " + mesic + " rok: " + rok + " věk: " + vek);
        }
    }
    else
    {
        Console.WriteLine("Chyba zadání rodného čísla");
    }
}
else
{
    Console.WriteLine("Chyba zadání rodného čísla");
}



