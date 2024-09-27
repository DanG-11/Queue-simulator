class Symulator_kolejki
{
    static Queue<string> klienci = new Queue<string>();

    static void StartProgramu()
    {
        Console.WriteLine("Witaj w symulatorze kolejki w sparze!");
    }

    static void DodawanieKlienta()
    {
        Console.WriteLine("Jakowe jest imię klienta którego chce pan dodać to kolejki?");
        string klient = Console.ReadLine();

        klienci.Enqueue(klient);
        Console.WriteLine("Klient " +  klient + " dodany do kolejki");
    }

    static void ObsluzenieKlienta()
    {
        string klient = klienci.Dequeue();

        Console.WriteLine("Obsłużono klienta: " + klient);
    }

    static void KlienciWKolejce()
    {
        Console.WriteLine("Jest " + klienci.Count + " w kolejce");

        Console.WriteLine("Klienci w kolejce:");

        foreach (string client in klienci)
        {
            Console.Write(client);
        }
    }

    public static void Main()
    {
        StartProgramu();
        Console.WriteLine("""
            1. Dodaj klienta
            2. Obsłuż klienta
            3. Informacje o klientach
            """);
        string wybor = Console.ReadLine();

        switch (wybor)
        {
            case "1":
                Console.WriteLine("Wybrałeś pierwszą opcję.");
                while (true)
                {
                    DodawanieKlienta();
                }
                break;

            case "2":
                Console.WriteLine("Wybrałeś pierwszą opcję.");
                while (true)
                {
                    ObsluzenieKlienta();
                }
                break;

            case "3":
                Console.WriteLine("Wybrałeś pierwszą opcję.");
                while (true)
                {
                    KlienciWKolejce();
                }
                break;
            default: 
                Console.WriteLine("Niema takiej opcji");
                break;
        }
    }   
}
