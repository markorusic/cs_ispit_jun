using System;
using System.Collections.Generic;

namespace cs_ispit_jun
{
  class Program
  {
    static void Main(string[] args)
    {
      var z1 = new Zadatak("zadatak 1", "odgovor", 4);
      var z2 = new Zadatak("zadatak 2", "odgovor", 3);
      var p1 = new Pitanje("pitanje 1",
        new List<Odgovor>() {
            new Odgovor(1, "odgovor 1", true),
            new Odgovor(2, "odgovor 2", false),
            new Odgovor(3, "odgovor 3", true),
            new Odgovor(4, "odgovor 4", false)
        }
      );

      var slozenProblem1 = new SlozenProblem();
      slozenProblem1.Dodaj(
        new Zadatak("slozen problem zadatak", "odgovor", 3)
      );
      slozenProblem1.Dodaj(
          new Pitanje("slozen problem pitanje 1", new List<Odgovor>() {
            new Odgovor(1, "odgovor 1", true),
            new Odgovor(2, "odgovor 2", false),
            new Odgovor(3, "odgovor 3", false),
            new Odgovor(4, "odgovor 4", false),
            new Odgovor(5, "odgovor 3", false),
            new Odgovor(6, "odgovor 3", false),
        })
      );
      slozenProblem1.Dodaj(
          new Pitanje("slozen problem pitanje 2", new List<Odgovor>() {
            new Odgovor(1, "odgovor 1", true),
            new Odgovor(2, "odgovor 2", false),
            new Odgovor(3, "odgovor 3", false),
            new Odgovor(4, "odgovor 4", false)
        })
      );

      var ispit = new SlozenProblem();
      ispit.Dodaj(z1);
      ispit.Dodaj(z2);
      ispit.Dodaj(p1);
      ispit.Dodaj(slozenProblem1);

      Console.WriteLine(
        $"Broj poena na ispitu: {ispit.BrojPoena}\n\nBroj koraka na ispitu: {ispit.BrojDelova}\n\nPitanja:\n{ispit.Tekst}"
      );
    }
  }
}
