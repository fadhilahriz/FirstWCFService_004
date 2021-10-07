using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FirstWCFService_004
{
    public class Service1 : IService1
    {
        public int Bagi(int a, int b)
        {
            return a / b;
        }
        public int Kali(int a, int b)
        {
            return a * b;
        }
        public int Kurang(int a, int b)
        {
            return a - b;
        }
        public int Tambah(int a, int b)
        {
            return a + b;
        }
        //TKoordinat: nama methodnya, a, b= input seperti int
        //Membuat koordinat hasil lalu menjumlahkan xa dengan xb, ya dengan yb lalu dimasukkan ke hasil
        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {
            Koordinat hasil = new Koordinat();
            hasil.X = a.X + b.X;
            hasil.Y = a.Y + b.Y;
            return hasil;
        }
    }
}
