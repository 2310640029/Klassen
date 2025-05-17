// See https://aka.ms/new-console-template for more information

// Abgeleitete Klasse von Polygon, die spezifische Eigenschaften und Methoden für ein Rechteck definiert.

internal class Rechteck : Polygon

{

    // Private Felder zur Speicherung der Seitenlängen des Rechtecks.
    private double seitenlaengeA;  // Eine Seitenlänge des Rechtecks
    private double seitenlaengeB;  // Die andere Seitenlänge des Rechtecks

    
    // Getter und Setter für die Eigenschaft SeitenlaengeA.
    public double SeitenlaengeA
    {
        get { return seitenlaengeA; }  // Gibt die Seitenlänge A zurück

        set  // Setter für Seitenlänge A
        {                       
            if (value< 0)  // Überprüfung auf negative Werte
            {
                seitenlaengeA = 0;  // Setzt die Seitenlänge auf 0, falls der Wert negativ ist
            }
            else
            {
                seitenlaengeA = value;  // Setzt die Seitenlänge auf den angegebenen Wert
            }
        }
    }
    
    // Getter und Setter für die Eigenschaft SeitenlaengeB.
    public double SeitenlaengeB
    {
        get { return seitenlaengeB; }  // Gibt die Seitenlänge B zurück
        set  // Setter für Seitenlänge B
        {
            if (value < 0)  // Überprüfung auf negative Werte
            {
                seitenlaengeB = 0;  // Setzt die Seitenlänge auf 0, falls der Wert negativ ist
            }
            else
            {
                seitenlaengeB = value;  // Setzt die Seitenlänge auf den angegebenen Wert
            }
        }
    }


    // Konstruktor, der die Seitenlängen des Rechtecks initialisiert.
    public Rechteck(double a, double b) : base(4)  // Rechteck hat immer 4 Seiten
    {
        SeitenlaengeA = a;  // Setzt die Seitenlänge A
        SeitenlaengeB = b;  // Setzt die Seitenlänge B
        BerechneFlaecheninhalt();  // Berechnet den Flächeninhalt beim Erstellen des Objekts
    }

    // Methode zur Berechnung des Flächeninhalts des Rechtecks.
    public void BerechneFlaecheninhalt()
    {
        // Berechnung des Flächeninhalts und Setzen des Wertes in der Basisklasse
        Flaecheninhalt = SeitenlaengeA * SeitenlaengeB;  // Berechnet den Flächeninhalt als Produkt der Seitenlängen
    }


    // Ausgabe Methode
    //public new void Ausgabe()

    // Methode zur Ausgabe, die die Methode der Basisklasse überschreibt.
    public override void Ausgabe()
    {
        // Gibt die spezifischen Informationen über das Rechteck aus, einschließlich der Seitenlängen und des Flächeninhalts.
        // Das $-Zeichen aktiviert String-Interpolation, wodurch Werte von Variablen oder Ausdrücke direkt in den String eingefügt werden, 
        // ohne zusätzliche Formatierungsfunktionen wie "String.Format" zu verwenden. D.h. Ein interpolierter String ermöglicht es,
        // Ausdrücke direkt innerhalb der geschweiften Klammern {} in den Text einzufügen und automatisch in eine Zeichenkette umzuwandeln.
        Console.WriteLine($"Rechteck mit den Seitenlängen A = {SeitenlaengeA}, B = {SeitenlaengeB}, und einem Flächeninhalt von {Flaecheninhalt}.");
    }
}