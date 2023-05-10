namespace Klassetrening;

class Studenter
{
    public string? Navn { get; private set; }
    public int Alder { get; private set; }
    public string? Kurs { get; private set; }
    public int KursId { get; private set; }

    public Studenter(string navn, int alder, string kurs, int kursId)
    {
        Navn = navn;
        Alder = alder;
        Kurs = kurs;
        KursId = kursId;
    }
}