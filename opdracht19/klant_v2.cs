using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace opdracht19
{
    public class klant
    {
        public int Id;
        public string Naam;
        public string Phone;
        public klant(int id, string name, string phone)
        {
            Id = id;
            Naam = name;
            Phone = phone;
        }
        public klant()
        {
            Id = 0;
            Naam = "";
            Phone = "";
        }
        public List<klant> Initialiseer()
        {
            klant marijk = new klant(1, "marijk", "0612345678");
            klant jan = new klant(2, "jan", "0612345677");
            klant tim = new klant(3, "tim", "0612345666");
            klant matt = new klant(4, "matt", "0612345555");
            klant jeff = new klant(5, "jeff", "0612344444");

            List<klant> klanten = new List<klant>();
            klanten.Add(marijk);
            klanten.Add(jan);
            klanten.Add(tim);
            klanten.Add(matt);
            klanten.Add(jeff);

            return klanten;
        }

        public string PrintKlant()
        {
            return $"[{this.Id}] {this.Naam} - {this.Phone}";
           
        }
    } 
}
