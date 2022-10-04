using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPAVI_Grupo2.Entidades
{
    public class Usuario
    {
        private string NombreUsuario;
        private string password;

        public Usuario()
        {
        }

        public Usuario(string nombre, string pass)
        {
            this.NombreUsuario = nombre;
            this.password = pass;
        }
        public string NombreDeusuario
        {
            get => NombreUsuario;
            set => NombreUsuario = value;
        }
        public string Contraseña
        {
            get => password;
            set => password = value;
        }

    }
}
