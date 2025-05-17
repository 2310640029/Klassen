// See https://aka.ms/new-console-template for more information

// Abgeleitete Klasse von Polygon, die spezifische Eigenschaften und Methoden für ein Quadrat definiert.

internal class Quadrat : Polygon
{

    // Private Feld zur Speicherung der Seitenlänge des Quadrats.
    private double seitenlaenge;  // Seitenlänge des Quadrats

    // Getter und Setter für die Eigenschaft Seitenlaenge.
    public double Seitenlaenge
    {
        get { return seitenlaenge; }  // Gibt die Seitenlänge zurück
        set  // Setter für die Seitenlänge
        {
            if (value < 0)  // Überprüfung auf negative Werte
            {
                seitenlaenge = 0;  // Setzt die Seitenlänge auf 0, falls der Wert negativ ist
            }
            else
            {
                seitenlaenge = value;  // Setzt die Seitenlänge auf den angegebenen Wert
            }
        }
    }


    // Konstruktor, der die Seitenlänge des Quadrats initialisiert.
    public Quadrat(double laenge) : base(4)  // Quadrat hat immer 4 Seiten
    {
        Seitenlaenge = laenge;  // Setzt die Seitenlänge
        BerechneFlaecheninhalt();  // Berechnet den Flächeninhalt beim Erstellen des Objekts
    }


    // Methode zur Berechnung des Flächeninhalts des Quadrats.
    public void BerechneFlaecheninhalt()
    {
        // Berechnung des Flächeninhalts und Setzen des Wertes in der Basisklasse
        Flaecheninhalt = Seitenlaenge * Seitenlaenge;  // Berechnet den Flächeninhalt als Quadrat der Seitenlänge
    }

    // Ausgabe Methode
    //public new void Ausgabe()

    // Methode zur Ausgabe, die die Methode der Basisklasse überschreibt.
    public override void Ausgabe()
    {
        // Gibt die spezifischen Informationen über das Quadrat aus, einschließlich der Seitenlänge und des Flächeninhalts.
        // Das $-Zeichen aktiviert String-Interpolation, wodurch Werte von Variablen oder Ausdrücke direkt in den String eingefügt werden, 
        // ohne zusätzliche Formatierungsfunktionen wie "String.Format" zu verwenden. D.h. Ein interpolierter String ermöglicht es,
        // Ausdrücke direkt innerhalb der geschweiften Klammern {} in den Text einzufügen und automatisch in eine Zeichenkette umzuwandeln.
        Console.WriteLine($"Quadrat mit der Seitenlänge = {Seitenlaenge} und einem Flächeninhalt von {Flaecheninhalt}.");
    }

}