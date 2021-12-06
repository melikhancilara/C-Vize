using System;
using System.Collections.Generic;
using System.Text;

namespace YemekTarifi.Sınıflar
{
    public class Yemek : Malzeme //kalıtım uyguladım.
    {
        public string yemekAdi;
        public List<string> malzemeListe = new List<string>();
    }
}
