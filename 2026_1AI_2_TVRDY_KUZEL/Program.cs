

double PI = 3.14;

double ObjemKuzela(double polomer, double vyska)
{
    // 1/3 * PI * r^2 * v
    double tVysledok = (1.0 / 3.0) * PI * polomer * polomer * vyska;
    return tVysledok;
}

double PovrchKuzela(double polomer, double strana)
{
    // PI * r * (r + s)
    double tVysledok = PI * polomer * (polomer + strana);
    return tVysledok;
}

Console.WriteLine("Aký je polomer?");
string nacitanyPolomer = Console.ReadLine();

Console.WriteLine("Aká je výška?");
string nacitanaVyska = Console.ReadLine();

Console.WriteLine("Aká je strana?");
string nacitanaStrana = Console.ReadLine();

Console.WriteLine();

Console.WriteLine("Polomer je " + nacitanyPolomer);
Console.WriteLine("Výška je " + nacitanaVyska);
Console.WriteLine("Strana je " + nacitanaStrana);

Console.WriteLine();

Console.WriteLine("Objem rotačného kužela je: " + ObjemKuzela(double.Parse(nacitanyPolomer), double.Parse(nacitanaVyska)));
Console.WriteLine("Povrch rotačného kužela je: " + PovrchKuzela(double.Parse(nacitanyPolomer), double.Parse(nacitanaStrana)));


