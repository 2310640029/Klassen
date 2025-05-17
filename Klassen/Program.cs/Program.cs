// See https://aka.ms/new-console-template for more information


// Das Übungsbeispiel besteht aus 2 Varianten, welche teilweise den Code der ersten Variante verändern!
// Der ursprüngliche Code wurde behalten, jedoch auskommentiert!!!

// Autor: Robert MARBAN, BITI3
class Program
{
    static void Main(string[] args)
    {
        // Ein Polygon-Objekt mit 5 Seiten wird erstellt.
        Polygon polygon = new Polygon(5);  // Erstellen eines Polygon-Objekts mit 5 Seiten
        polygon.Ausgabe();  // Ausgabe der Informationen über das Polygon

        // Ein Rechteck-Objekt mit den Seitenlängen 5 und 10 wird erstellt.
        Rechteck rechteck = new Rechteck(5.0, 10.0);  // Erstellen eines Rechteck-Objekts mit den angegebenen Seitenlängen
        rechteck.Ausgabe();  // Ausgabe der Informationen über das Rechteck

        // Ein Quadrat-Objekt mit einer Seitenlänge von 4 wird erstellt.
        Quadrat quadrat = new Quadrat(4.0);  // Erstellen eines Quadrat-Objekts mit der angegebenen Seitenlänge
        quadrat.Ausgabe();  // Ausgabe der Informationen über das Quadrat

        // Wartet auf eine Benutzereingabe, um das Konsolenfenster offen zu halten.
        Console.ReadLine();
    }
}