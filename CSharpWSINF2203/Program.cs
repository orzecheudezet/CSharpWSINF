using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpWSINF2203
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nie korzystamy z Array list juz = kolekcja niegeneryczna
            ArrayList lista = new ArrayList(1000);
            lista.Add(2);
            lista.Add(3);
            Console.WriteLine(lista[0]);
            lista.Add("Trololo");
            int suma = (int)lista[0] + (int)lista[1];
            //int liczba = (int)lista[2];
            List<int> liczby = new List<int>();
            //typ generyczny zawiera parametry generyczne, parametr generyczny tez jest typem.

            liczby.Add(2);
            int x = liczby[0];

            //Struktury się nie dziedziczą!

            //Słownik to lista par(klucz, wartość)Przechowywanie ustawień login hasło
            // Najczęściej kluczem jest string albo int, słownik nie musi być ciągły(indeksy nie muszą być po koleji)
            Dictionary<String, String> słownik = new Dictionary<string, string>(); // String = string ? 

            słownik["login"] = "jasio";
            słownik["hasło"] = "haslo123";
            foreach (String klucz in słownik.Keys)
            {
                Console.WriteLine(klucz + " " + słownik[klucz]);
            }

            foreach (String wartosc in słownik.Values)
            {
                Console.WriteLine(wartosc);            // wartosc moze sie powatarzac ale klucze musza byc unikatowe
            }

            foreach (KeyValuePair<String, String> para in słownik)
            {
                Console.WriteLine(para.Key + " " + para.Value);
            }
            List<int> doSorotwania = new List<int>(new[] { 3, 5, 2, 7 });
            doSorotwania.Sort();

            foreach (int element in doSorotwania)
            {
                Console.WriteLine(element);
            }

            Student student = new Student();
            student.Imie = "Jan";
            student.Nazwisko = "Kowalski";
            student.NrIndeksu = "123456";

            Student s2 = new Student { Imie = "Andrzej", Nazwisko = "Nowak", NrIndeksu = "012345" };
            // Konstruktor bez konstrukotra, madre xD

            List<Student> studenci = new List<Student>();
            studenci.Add(student);
            studenci.Add(s2);
            studenci.Sort();  // musimy powiedziec po czym sortujemy
            foreach (Student s in studenci)
                Console.WriteLine(s);

            int? zmienna = null; // trzeba pamietac, że to nie jest int tylko nullable moze byc dowolnym typem wartosci
                                 // nullable jest struktura parametr t jest struktura 

            // SET - zbiór to kolekcja. Cechą zbioru jest to ,że przechowuje tylko elementy unikalne
            // njaprostszy jest hashtset typ generyczn
            // nie ma dostepu indeksowanego
            

            HashSet<int> zbior = new HashSet<int>();
            zbior.Add(3);
            zbior.Add(4);
            zbior.Add(3);
            Console.WriteLine(zbior.Count);
            foreach (int liczba in zbior)
            {
                Console.WriteLine(liczba);
            }

            HashSet<Student> studentSet = new HashSet<Student>();
            studentSet.Add(s2);
            studentSet.Add(student);
            studentSet.Add(s2);
            studentSet.Add(new Student { Imie = "Jan", Nazwisko = "Kowalski", NrIndeksu = "123456" });
            Console.WriteLine(studentSet.Count);
            Console.WriteLine();
            // Porownuje wkaźniki
            HashSet<int> losowane = new HashSet<int>();
            Lotto(losowane);
            foreach (int los in losowane)
                Console.WriteLine(los);

            SortedSet<int> sortowane = new SortedSet<int>();
            Lotto(sortowane);
            foreach (int los in sortowane)
                Console.WriteLine(los);
            Console.ReadKey();
        }
        // klasa main korzysta tylko ze tatycznych metod 
        static void Lotto(ISet<int> liczby) // ISet zadziała dla sortedset tak samo jak hashset
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            liczby.Clear();
            while (liczby.Count < 6)
                liczby.Add(rand.Next(49) + 1);
        }
    }
    class Student : IComparable<Student> // czym sie rozni od IComperer
    {
        public String Imie { get; set; }
        public String Nazwisko { get; set; }
        public String NrIndeksu { get; set; }

        public int CompareTo(Student other)
        {
            int porownanieNazwisk = this.Nazwisko.CompareTo(other.Nazwisko);
            if (porownanieNazwisk == 0)
                return this.Imie.CompareTo(other.Imie);
            else
                return porownanieNazwisk;
        }

        public override string ToString()
        {
            return this.Imie + " " + this.Nazwisko + ", " + this.NrIndeksu;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (this == obj)
                return true;
            if (obj is Student)
            {
                Student s = obj as Student;
                return this.NrIndeksu == s.NrIndeksu;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return int.Parse(this.NrIndeksu);
        }
    }

}
