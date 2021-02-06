using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Ogrenci = new MyDictionary<int, string>();
            Ogrenci.Add(134, "Tolga Demir");
            Ogrenci.Add(158, "Ayşe Kara");
            Ogrenci.Add(115, "Nazlı Coşkun");
            Ogrenci.Add(174, "Kemal Çiftçi");
            Ogrenci.List();
        }
    }
}
