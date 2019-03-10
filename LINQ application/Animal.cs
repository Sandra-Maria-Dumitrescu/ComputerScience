using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodeAvansate_DEMO
{
    class Animal
    {
        public int id;
        public String nume;
        public String specie;
        public Rasa rasa;
        public Culoare culoare;

        public Animal() {

        }

        public Animal(int id, String nume,String specie,Rasa rasa,Culoare culoare) {
            this.id = id;
            this.nume = nume;
            this.specie = specie;
            this.rasa = rasa;
            this.culoare = culoare;
        }

        public int getId() {
            return id;
        }

        public void setId(int id) {
            this.id = id;
        }
        public String getNume() {
            return nume;
        }
        public void setName(String nume) {
            this.nume = nume;
        }

        public String getSpecie() {
            return specie;
        }

        public void setSpecie(String specie) {
            this.specie = specie;
        }

        public Rasa getRasa() {
            return rasa;
        }

        public void setRasa(Rasa rasa) {
            this.rasa = rasa;
        }

        public Culoare getCuloare() {
            return Culoare.Verde;
        }

        public void setCuloare(Culoare culoare) {
            this.culoare = culoare;
        }


        public override string ToString()
        {
            return "ID aniaml: " + id+" Nume: "+ nume+" Specie :"+ specie+" Rasa: "+ rasa+" Culoare :"+ culoare;
        }

    }
}
