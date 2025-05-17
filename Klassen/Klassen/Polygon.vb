Public Class Polygon

End Class
{
    // Private Felder
    private int anzahlSeiten;
    private double flaecheninhalt;

    // Getter und Setter
    public int AnzahlSeiten
    {
        get { return anzahlSeiten; }
        set { anzahlSeiten = value < 0 ? 0 : value; } // Keine negativen Seiten
    }

    public double Flaecheninhalt
    {
        get { return flaecheninhalt; }
        private set { flaecheninhalt = value < 0 ? 0 : value; } // Flaecheninhalt ist privat
    }

    // Konstruktor
    public Polygon(int seiten = 4)
    {
        AnzahlSeiten = seiten;  // Default 4 Seiten
        Flaecheninhalt = 0;     // Polygon kann Flaecheninhalt nicht berechnen
    }

    // Ausgabe Methode
    public void Ausgabe()
    {
        Console.WriteLine($"Polygon mit {AnzahlSeiten} Seiten und einem Flächeninhalt von {Flaecheninhalt}.");
    }
}