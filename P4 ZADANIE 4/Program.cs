using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_ZADANIE_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyTPTc = new MyTPTContext();
            MyTPTc.Osoby.Add(new Pracownik() { Imie = "Marcin", Nazwisko = "Zuziak" ,DataZatrudnienia= DateTime.Now, DataZwolnienia=null});
            MyTPTc.Osoby.Add(new Klient() { Imie = "Marek", Nazwisko = "Guziak", NrTelefonu="123-456-789",NrRejestracyjny="SBI 4567" });
            MyTPTc.SaveChanges();

            var MyTPHc = new MyTPHContext();
            MyTPHc.Osoby.Add(new Pracownik() { Imie = "Marcin", Nazwisko = "Zuziak", DataZatrudnienia = DateTime.Now, DataZwolnienia = null });
            MyTPHc.Osoby.Add(new Klient() { Imie = "Marek", Nazwisko = "Guziak", NrTelefonu = "123-456-789", NrRejestracyjny = "SBI 4567" });
            MyTPHc.SaveChanges();


        }
    }
}
