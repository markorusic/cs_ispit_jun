using System;
using System.Collections.Generic;
using System.Linq;

namespace cs_ispit_jun
{

  public class Pitanje : Problem
  {
    private string tekst;

    private List<Odgovor> odgovori;

    public Pitanje(string _tekst, List<Odgovor> _odgovori) : base()
    {
      tekst = _tekst;
      odgovori = _odgovori;

    }
    public override int BrojDelova => 1;

    public override int BrojPoena => odgovori.Count / 2;

    public override string Tekst => tekst;

    public override string Odgovor =>
      String.Join(", ", (
        from odgovor in odgovori
        where odgovor.Tacnost
        select odgovor.RedniBroj
      ));

    public override string ToString()
    {
      return $"bp: {BrojPoena}, odgovor: {Odgovor}";
    }
  }
}