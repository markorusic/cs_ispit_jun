using System;

namespace cs_ispit_jun
{
  public class Zadatak : Problem
  {

    private string tekst;

    private string odgovor;

    private int brojPoena;

    public Zadatak(string _tekst, string _odgovor, int _brojPoena) : base()
    {
      tekst = _tekst;
      odgovor = _odgovor;
      brojPoena = _brojPoena;
    }
    public override int BrojDelova => 1;

    public override int BrojPoena => brojPoena;

    public override string Tekst => tekst;

    public override string Odgovor => odgovor;
  }
}
