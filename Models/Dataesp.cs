using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APINodeMcu.Models
{
    public class Dataesp
    {
        public Dataesp(string oxiValor, string freqValor, int dispValor, string tempValor)
        {
            
            this.oxiValor = oxiValor;
            this.freqValor = freqValor;
            this.dispValor = dispValor;
            this.tempValor = tempValor;

        }

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string oxiValor { get; set; }

        [Required]
        public string freqValor { get; set; }

        [Required]
        public int dispValor { get; set; }

        [Required]
        public string tempValor { get; set; }



    }
}
