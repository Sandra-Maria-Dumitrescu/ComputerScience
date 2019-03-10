using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodeAvansate_DEMO
{
    class Proprietar
    {
        public int id;
        public String nume;
        public String adresa;
        public Animal animal;

        public Proprietar() {

        }

        public Proprietar(int id,String nume,String adresa,Animal a) {
            this.id = id;
            this.nume = nume;
            this.adresa = adresa;
            this.animal = a;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public String getNume()
        {
            return nume;
        }
        public void setName(String nume)
        {
            this.nume = nume;
        }

        public String getAdresa()
        {
            return adresa;
        }

        public void setAdresa(String adresa)
        {
            this.adresa = adresa;
        }

        public Animal getAnimal()
        {
            return animal;
        }

        public void setAnimal(Animal a)
        {
            this.animal = a;
        }


    }
}
