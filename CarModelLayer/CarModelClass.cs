using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CarModelLayer
{
    public class CarModelClass
    {
        [DisplayName("Model")]
        public string Model { get; set; }


        [DisplayName("Description")]
        public string Description { get; set; }


        [DisplayName("Horsepower")]
        public string Horsepower { get; set; }
    }

}
