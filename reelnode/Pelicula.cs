using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoNuevo
{
    public class Pelicula
    {
        public string Nombre { get; set; }
        public DateTime FechaEstreno {  get; set; }
        public string Descripcion { get; set; }
        public string Director {  get; set; }
        public Image Imagen { get; set; }
        public string Duracion { get; set; }

        public Pelicula() { }
        public Pelicula(string nombre, DateTime fechaEstreno, string descripcion, string director, Image img, string duracion ) 
        {
            this.Nombre = nombre;
            this.FechaEstreno = fechaEstreno;
            this.Descripcion = descripcion;
            this.Director = director;
            this.Imagen = img;
            this.Duracion = duracion;
        }
        
    }
}
