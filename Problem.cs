namespace cs_ispit_jun
{
  public abstract class Problem
  {
    private static int brojProblema = 0;

    private int redniBroj;

    public Problem()
    {
      brojProblema++;
      redniBroj = brojProblema;
    }

    public int RedniBroj { get => redniBroj; }

    public abstract int BrojPoena { get; }

    public abstract int BrojDelova { get; }

    public abstract string Tekst { get; }

    public abstract string Odgovor { get; }
  }
}
