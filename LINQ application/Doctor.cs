using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodeAvansate_DEMO
{

   
    class Doctor
    {
        public int id;
        public String nume;
        public String adresa;
        public int animal_id;
        public double salary;

        public Doctor() { }


        public Doctor(int id, String nume, String adresa,int animal_id,double salary) {
            this.id = id;
            this.nume = nume;
            this.adresa = adresa;
            this.animal_id = animal_id;
            this.salary = salary;
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

        public void setAnimale(int animal_id)
        {
            this.animal_id = animal_id;
        }

        public int getAnimale() {
            return animal_id;
        }
        public void setSalary(double salary)
        {
            this.salary = salary;
        }

        public double getSalary()
        {
            return salary;
        }


    }
}
