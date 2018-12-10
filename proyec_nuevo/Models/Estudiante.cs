using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyec_nuevo.Models
{
    public class Estudiante
    {
       public int Carnet { get; set; }
       public string Nombre { get; set;}
       public string Materia { get; set; }
       public double Promedio { get; set; }
       public DateTime FechaRegistro { get; set; }

        public List<Estudiante> lista()
        {
            var estudiante1 = new Estudiante()
            {
                Carnet = 001,
                Nombre = "Josue",
                Materia = "Habilidades Blandas",
                Promedio = 8.4,
                FechaRegistro = DateTime.Now
            };

            var estudiante2 = new Estudiante()
            {
                Carnet = 002,
                Nombre = "Gerard",
                Materia = "Musica",
                Promedio = 9.9,
                FechaRegistro = DateTime.Now
            };

            var estudiante3 = new Estudiante()
            {
                Carnet = 003,
                Nombre = "Maria",
                Materia = "gestion de baces de datos",
                Promedio = 8.5,
                FechaRegistro = DateTime.Now
            };

            var estudiante4 = new Estudiante()
            {
                Carnet = 004,
                Nombre = "Nayid",
                Materia = "Matematicas",
                Promedio = 6.5,
                FechaRegistro = DateTime.Now
            };

            var estudiante5 = new Estudiante()
            {
                Carnet = 005,
                Nombre = "Sanchez Ceren",
                Materia = "Lenguaje",
                Promedio = 3.5,
                FechaRegistro = DateTime.Now
            };
            return new List<Estudiante>() {estudiante1, estudiante2, estudiante3, estudiante4, estudiante5};
        }
    }
}