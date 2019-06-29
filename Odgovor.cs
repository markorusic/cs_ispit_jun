namespace cs_ispit_jun
{
  public class Odgovor
  {
    private string tekst;

    private bool tacnost;

    private int redniBroj;

    public Odgovor(int _redniBroj, string _tekst, bool _tacnost)
    {
      tekst = _tekst;
      tacnost = _tacnost;
      redniBroj = _redniBroj;
    }
    public string Tekst { get => tekst; }

    public bool Tacnost { get => tacnost; }

    public int RedniBroj { get => redniBroj; }
  }
}
