using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar
{
    internal class Usuario
    {
        private int Id;
        private string TipoId;
        private string Nombre;
        private string Apellido;
        private string TipoUsuario;
        private int Celular;
        private string Correo;

        public Usuario() {

            Id = 123456789;
            TipoId = "CC";
            Nombre = "Pepito de Jesus";
            Apellido = "Perez Gomez";
            TipoUsuario = "Cliente"; // Consultar como devolver el tipo de usuario por un metodo
            Celular = 321000000;
            Correo = "Pepito.perez@gmail.com";

        }    

        public int Id1 { get => Id; set => Id = value; }
        public string TipoId1 { get => TipoId; set => TipoId = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string TipoUsuario1 { get => TipoUsuario; set => TipoUsuario = value; }
        public int Celular1 { get => Celular; set => Celular = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
    }
}

