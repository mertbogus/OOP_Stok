using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityMusteri
    {
        private byte musteriıd;
        private string musteriad;
        private string musterisoyad;

        public byte Musteriıd { get => musteriıd; set => musteriıd = value; }
        public string Musteriad { get => musteriad; set => musteriad = value; }
        public string Musterisoyad { get => musterisoyad; set => musterisoyad = value; }
    }
}
