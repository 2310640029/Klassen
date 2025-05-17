using System;

public class Rechteck : Polygon
{
    // Private Felder
    private double seitenlaengeA;
    private double seitenlaengeB;

    // Getter und Setter
    public double SeitenlaengeA
    {
        get { return seitenlaengeA; }
        set { seitenlaengeA = value < 0 ? 0 : value; }  // Keine negativen Längen
    }

    public double SeitenlaengeB
    {
        get { return seitenlaengeB; }
        set { seitenlaengeB = value < 0 ? 0 : value; }  // Keine negativen Längen
    }

    // Konstruktor
    public Rechteck(double laengeA, double laengeB) : base(4)  // Rechteck hat immer 4 Seiten
    {
        SeitenlaengeA = laengeA;
        SeitenlaengeB = laengeB;
        BerechneFlaecheninhalt();
    }

    // Methode zur Berechnung des Flächeninhalts
    public void BerechneFlaecheninhalt()
    {
        Flaecheninhalt = SeitenlaengeA * SeitenlaengeB;
    }

    // Ausgabe Methode
    public new void Ausgabe()
    {
        Console.WriteLine($"Rechteck mit Seitenlängen A = {SeitenlaengeA}, B = {SeitenlaengeB}, und einem Flächeninhalt von {Flaecheninhalt}.");
    }
}
