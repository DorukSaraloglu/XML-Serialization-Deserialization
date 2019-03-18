using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Serialization_Deserialization
{
    public class Ogrenci
    {
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarih { get; set; }

        public Ogrenci()
        {
            this.Id = Guid.NewGuid();
        }
        public override string ToString()
        {
            return Ad;
        }
    }
}
