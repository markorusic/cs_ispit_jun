using System.Collections.Generic;
using System.Linq;

namespace cs_ispit_jun
{
  public class SlozenProblem : Problem
  {

    List<Problem> problemi = new List<Problem>();

    public SlozenProblem() : base()
    {
    }

    public override int BrojPoena => (
      from problem in problemi
      select problem.BrojPoena
    ).Sum();

    public override int BrojDelova => (
      from problem in problemi
      select problem.BrojDelova
    ).Sum();

    public override string Tekst =>
      string.Join("\n", (
        from problem in problemi
        select problem.Tekst
      ));

    public override string Odgovor => string.Join("\n", (
        from problem in problemi
        select problem.Odgovor
      ));

    public void Dodaj(Problem problem)
    {
      problemi.Add(problem);
    }

    public void Izbaci(Problem problem)
    {
      problemi.Remove(problem);
    }

    public void IzbaciSve()
    {
      problemi.Clear();
    }
  }
}
