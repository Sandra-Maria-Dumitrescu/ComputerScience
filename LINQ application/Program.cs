using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodeAvansate_DEMO
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal a1 = new Animal(1,"jessie","asd",Rasa.Labrador,Culoare.Rosu);
            Animal a2 = new Animal(2, "rex", "asdd", Rasa.Husky, Culoare.Negru);
            Animal a3 = new Animal(3, "Timmy", "asdd", Rasa.Labrador, Culoare.Verde);
            Animal a4 = new Animal(4, "Patrocle", "asdd", Rasa.Pug, Culoare.Rosu);
            Animal a5 = new Animal(5, "taya", "asdd", Rasa.Labrador, Culoare.Negru);
            Animal a6 = new Animal(6, "maya", "asdd", Rasa.Labrador, Culoare.Verde);
            Proprietar p1 = new Proprietar(1, "madalin", "Pitesti", a1);
            Proprietar p2 = new Proprietar(2, "sandra", "Pitesti", a3);
            Proprietar p3 = new Proprietar(3, "marian", "Bucuresti", a5);
            Animal[] animale = new Animal[] {a1,a2,a3,a4,a5,a6};
            Proprietar[] proprietari = new Proprietar[] { p1, p2, p3 };
            Doctor d1 = new Doctor(1, "Ionescu", "Pitesti", 1,2300);
            Doctor d2 = new Doctor(2, "Popescu", "Pitesti", 2,3000);
            Doctor[] doctori=new Doctor[]{d1,d2};

            //Exemplul 1) where conditie simpla
            Console.WriteLine("Exemplu conditie where");
            var exp = from a in animale
                      where a.culoare == Culoare.Rosu
                      select new { a.id, a.nume };

            foreach (var a in exp)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 2) ordonare dupa nume descrescator
            Console.WriteLine("Exemplu conditie OrderByDescending");
            var exp2 = from a in animale
                       orderby a.nume descending
                       select new { a.id, a.nume };

            foreach (var a in exp2)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 3) ordonare dupa nume crescator unde rasa este labrador de culoare verde
            Console.WriteLine("Exemplu conditie OrderBy");
            var exp3 = from a in animale
                       where a.rasa == Rasa.Labrador && a.culoare == Culoare.Verde
                       orderby a.nume ascending
                       select new { a.id, a.nume };
            foreach (var a in exp3)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 4) select cu restrictie si filtrare bazata pe index
            Console.WriteLine("Exemplu select cu restrictie si filtrare bazata pe index");
            var exp4 = animale.Where((a, index) => (a.rasa == Rasa.Labrador && index > 2)).Select(a => a.nume);
            foreach (var a in exp4)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine();
            Console.WriteLine();

            //Exemplul 5) select toti cainii care sunt verzi si pentru care numele incepe cu T
            Console.WriteLine("select toti cainii care sunt verzi si pentru care numele incepe cu T");
            var exp5 = from a in animale
                       where a.culoare == Culoare.Verde && a.nume.ToLower().StartsWith("t")
                       select new { a.id, a.nume };

            foreach (var a in exp5)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 6) select toate animalele care sunt labradori, intai ordonate descrescator dupa id si apoi ordonate descrescator dupa culoare
            Console.WriteLine("select toate animalele care sunt labradori, intai ordonate descrescator dupa id si apoi ordonate desc dupa culoare");
            var exp6 = animale
                .Where(c => c.rasa == Rasa.Labrador)
                .OrderByDescending(c => c.id)
                .ThenByDescending(c => c.culoare)
                .Select(c => new { c.id, c.nume, c.rasa, c.culoare });
            foreach (var a in exp6)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 7) reverse ca la 6)
            Console.WriteLine("reverse ca la 6)");
            var exp7 = (animale
                .Where(c => c.rasa == Rasa.Labrador)
                .OrderByDescending(c => c.id)
                .ThenByDescending(c => c.culoare)
                .Select(c => new { c.id, c.nume, c.rasa, c.culoare }))
                .Reverse();
            foreach (var a in exp7)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 8) grupare animale dupa culoare
            Console.WriteLine("grupare animale dupa culoare");
            var expr8 =
                      from c in animale
                      group c by c.culoare;

            foreach (IGrouping<Culoare, Animal> animalGroup in expr8)
            {
                Console.WriteLine("culoare: {0}", animalGroup.Key);
                foreach (var item in animalGroup)
                {
                    Console.WriteLine("\t{0}", item);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 9) afisarea numarului de animale in functie de culoarea acestora
            Console.WriteLine("afisarea numarului de animale in functie de culoarea acestora");
            var expr9 =
                      from c in animale
                      group c by c.culoare into animaleGroup
                      select new
                      {
                          culoare = animaleGroup.Key,
                          countCuloare = animaleGroup.Count()
                      };
            foreach (var a in expr9)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 10) numele cainilor care au proprietar
            Console.WriteLine("afiseaza numele cainilor care au proprietar");
            var expr10 =
                from c in proprietari
                join s in animale
                on c.animal.id equals s.id
                select new { s.nume };
            foreach (var a in expr10)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 11) operatorul union (afiseaza cainii din rasa Husky si Labrador)
            Console.WriteLine("operatorul union (afiseaza cainii din rasa Husky si Labrador)");
            var expr11 = (from a in animale
                          where a.rasa == Rasa.Husky
                          select a).Union(from a in animale
                                          where a.rasa == Rasa.Labrador
                                          select a);
            foreach (var aaa in expr11)
            {
                Console.WriteLine(aaa.nume + " is " + aaa.rasa);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 12) operatorul inner join (afiseaza animalele care au un doctor)
            Console.WriteLine("operatorul inner join (afiseaza animalele care au un doctor)");
            var animalsWDoc = from a in animale
                              join d in doctori
                              on a.id equals d.animal_id
                              select new { DoctorName = d.nume, AnimalName = a.nume };

            foreach (var i in animalsWDoc)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 13) operatorul Intersect (afiseaza labradorii verzi)
            Console.WriteLine("operatorul Intersect (afiseaza labradorii verzi)");
            var expr13 = (from a in animale
                          where a.rasa == Rasa.Labrador
                          select a).Intersect(from a in animale
                                              where a.culoare == Culoare.Verde
                                              select a);
            foreach (var aaa in expr13)
            {
                Console.WriteLine("nume: " + aaa.nume + " rasa: " + aaa.rasa + " color:" + aaa.culoare);
            }
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 14) numarul de animale din fiecare rasa // folosire count
            Console.WriteLine("numarul de animale din fiecare rasa // folosire count");
            var exp14 = from a in animale
                        group a by a.rasa;

            foreach (IGrouping<Rasa, Animal> animale1 in exp14)
            {
                Console.WriteLine("{1} animale din rasa {0}", animale1.Key, animale1.Count());
                //foreach (var i in animale1)
                //{
                //    Console.WriteLine("  Nume caine: {0}",i.nume);
                // }
            }
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 15) salariul minim al doctorilor
            Console.WriteLine("salariul minim al doctorilor");
            var exp15 = (from d in doctori select new { d.nume, d.salary }).Min(d => d.salary);
            Console.WriteLine("medicul cu cel mai mic salariu este:" + exp15);
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 16) salariul maxim al unui doctor
            Console.WriteLine("salariul maxim al unui doctor");
            var exp16 = (from d in doctori
                         select new { d.nume, d.salary }).Max(d => d.salary);
            Console.WriteLine("medicul cu cel mai mare salariu este:" + exp16);
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 17) functia first care ne aduce primul element din sir
            Console.WriteLine("functia first care ne aduce primul element din sir");
            var exp17 = (from a in animale select new { a.nume, a.rasa, a.culoare }).First();
            Console.WriteLine(exp17);
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 18) functia lastordefault aduce ultimul salariu mai mare sau egal cu 3100, in caz ca acesta nu exista returneaza null
            Console.WriteLine("functia lastordefault aduce ultimul salariu mai mare sau egal cu 3100, in caz ca acesta nu exista returneaza null");
            var exp18 = (from d in doctori select new { d.nume, d.salary }).LastOrDefault(d => d.salary >= 3100);
            Console.WriteLine(exp18 == null ? "null" : exp18.ToString());
            Console.WriteLine();
            Console.WriteLine();
            //Exemplul 19) functia ElementAt returneaza proprietarul care este din Pitesti de pe pozitia 2 in sir, daca nu exista returneaza null 
            Console.WriteLine("functia ElementAt returneaza proprietarul care este din Pitesti de pe pozitia 2 in sir, daca nu exista returneaza null");
            var exp19 = (from p in proprietari where p.adresa == "Pitesti" select new { p.nume, p.adresa }).ElementAt(1);
            Console.WriteLine(exp19 == null ? "null" : exp19.ToString());
            Console.ReadKey();
        }

    }
}
