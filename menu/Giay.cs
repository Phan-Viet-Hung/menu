using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Giay
    {
        public string giayId;
        public string tenGiay;
        public string thuongHieu;
        public int size;
        public string mauSac;
        public double gia;
        public int tonKho;

        public Giay(string giayId, string tenGiay, string thuongHieu, int size, string mauSac, double gia, int tonKho)
        {
            this.giayId = giayId;
            this.tenGiay = tenGiay;
            this.thuongHieu = thuongHieu;
            this.size = size;
            this.mauSac = mauSac;
            this.gia = gia;
            this.tonKho = tonKho;
        }

    }
}
