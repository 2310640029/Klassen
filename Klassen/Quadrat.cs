using System;

public class Quadrat : Polygon
{
    // Private Felder
    private double seitenlaenge;

    // Getter und Setter
    public double Seitenlaenge
    {
        get { return seitenlaenge; }
        set { seitenlaenge = value < 0 ? 0 : value; }  // Keine negativen Längen
    }

    // Konstruktor
    public Quadrat(double laenge) : base(4)  // Quadrat hat immer 4 Seiten
    {
        Seitenlaenge = laenge;
        BerechneFlaecheninhalt();
    }

    // Methode zur Berechnung des Flächeninhalts
    public void BerechneFlaecheninhalt()
    {
        Flaecheninhalt = Seitenlaenge * Seitenlaenge;
    }

    // Ausgabe Methode
    public new void Ausgabe()
    {
        Console.WriteLine($"Quadrat mit Seitenlänge = {Seitenlaenge} und einem Flächeninhalt von {Flaecheninhalt}.");
    }
}
