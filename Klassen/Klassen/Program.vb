Imports System

Class Program
End Class
{
    Static void Main(String[] args)
    {
        // Polygon Objekt erstellen
        Polygon polygon = New Polygon();
        polygon.Ausgabe();

        // Rechteck Objekt erstellen
        Rechteck rechteck = New Rechteck(5.0, 10.0);
        rechteck.Ausgabe();

        // Quadrat Objekt erstellen
        Quadrat quadrat = New Quadrat(4.0);
        quadrat.Ausgabe();

        // Halte die Konsole offen
        Console.ReadLine();
    }
}