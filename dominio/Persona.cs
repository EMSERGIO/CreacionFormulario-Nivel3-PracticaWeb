using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Casado { get; set; }
        public bool Argentino { get; set; }
    }
    public class PersonaNegocio
    {
        public List<Persona> listar()
        {
            List<Persona> lista = new List<Persona>();
            lista.Add(new Persona());
            lista.Add(new Persona());

            lista[0].Id = 1;
            lista[0].Nombre = "Maxi";
            lista[0].Edad = 32;
            lista[0].FechaNacimiento = DateTime.Now;
            lista[0].Casado = true;
            lista[0].Argentino = false;

            lista[1].Id = 2;
            lista[1].Nombre = "Pepe";
            lista[1].Edad = 21;
            lista[1].FechaNacimiento = DateTime.Now;
            lista[1].Casado = false;
            lista[1].Argentino = true;

            return lista;

        }
    }

}
