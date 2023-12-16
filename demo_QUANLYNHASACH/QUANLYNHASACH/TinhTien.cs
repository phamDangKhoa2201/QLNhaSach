using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHASACH
{
    class TinhTien
    {
        float dongia;
        int sl;

        public float Dongia { get => dongia; set => dongia = value; }
        public int Sl { get => sl; set => sl = value; }
        public TinhTien()
        {
            Dongia = Sl = 0;
        }
        public TinhTien(float b, int a)
        {
            Dongia = b;
            Sl = a;
        }
        public float ThanhTien()
        {
            return Sl * Dongia;
        }
        
    }

}
