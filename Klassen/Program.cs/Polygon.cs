// See https://aka.ms/new-console-template for more information

// Basisklasse für geometrische Formen, die die grundlegenden Eigenschaften eines Polygons definiert.

internal class Polygon
{
    // Private Felder zur Speicherung der Anzahl der Seiten und des Flächeninhalts.
    private int anzahlSeiten;  // Anzahl der Seiten des Polygons
    private double flaecheninhalt;  // Flächeninhalt des Polygons

    // Getter und Setter für die Eigenschaft AnzahlSeiten.
    public int AnzahlSeiten
    {
        get { return anzahlSeiten; }  // Gibt die Anzahl der Seiten zurück

        set  // Setter für die Anzahl der Seiten
        {
            if (value < 0)  // Überprüfung auf negative Werte
            {
                anzahlSeiten = 0;  // Setzt die Anzahl der Seiten auf 0, falls der Wert negativ ist
            }
            else
            {
                anzahlSeiten = value;  // Setzt die Anzahl der Seiten auf den angegebenen Wert
            }
        }
    }

    // Getter und Setter für die Eigenschaft Flaecheninhalt.
    public double Flaecheninhalt
    {
        get { return flaecheninhalt; }  // Gibt den Flächeninhalt zurück

        protected set  // Der Setter ist protected, damit abgeleitete Klassen den Wert setzen können
        {
            {
                if (value < 0)  // Überprüfung auf negative Werte
                {
                    flaecheninhalt = 0;  // Setzt den Flächeninhalt auf 0, falls der Wert negativ ist
                }
                else
                {
                    flaecheninhalt = value;  // Setzt den Flächeninhalt auf den angegebenen Wert
                }
            }
        }
    }

    // Konstruktor, der die Anzahl der Seiten festlegt und den Flächeninhalt initialisiert.


    //public Polygon()
    //{
    //    AnzahlSeiten = 4;  // Default 4 Seiten
    //    Flaecheninhalt = 0;     // Polygon kann Flaecheninhalt nicht berechnen
    //}


    public Polygon(int anzahlSeiten)
    {
        AnzahlSeiten = anzahlSeiten;  // Setzt die Anzahl der Seiten über den Setter
        Flaecheninhalt = 0;  // Setzt den Flächeninhalt auf 0, da ein Polygon keinen Flächeninhalt berechnen kann
    }

    // Ausgabe Methode
    //public new void Ausgabe()

    // Virtuelle Methode zur Ausgabe von Informationen über das Polygon.
    public virtual void Ausgabe()
    {
        // Gibt die Anzahl der Seiten und den Flächeninhalt des Polygons aus.
        // Das $-Zeichen aktiviert String-Interpolation, wodurch Werte von Variablen oder Ausdrücke direkt in den String eingefügt werden, 
        // ohne zusätzliche Formatierungsfunktionen wie "String.Format" zu verwenden. D.h. Ein interpolierter String ermöglicht es,
        // Ausdrücke direkt innerhalb der geschweiften Klammern {} in den Text einzufügen und automatisch in eine Zeichenkette umzuwandeln.
        Console.WriteLine($"Polygon mit {AnzahlSeiten} Seiten und einem Flächeninhalt von {Flaecheninhalt}.");
    }
}
