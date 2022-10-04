using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPAVI_Grupo2.Entidades
{
    public class Personal
    {
        private int Legajo;
        private int Tipo;
        private string Documento;
        private string Apellido;
        private string Nombre;
        private int Usuario;
        private DateTime FechaIngreso;
        private DateTime FechaEgreso;
        private int MotivoEgreso;
        private int IdBarrio;
        private string Calle;
        private int NroCalle;
        private DateTime FecNacimiento;
        private int CodigoProyecto;

        public int LegajoPersonal
        {
            get => Legajo;
            set => Legajo = value;
        }
        public Personal()
        {
        }
        public int TipoDocPersonal
        {
            get => Tipo;
            set => Tipo = value;
        }
        public string DocumentoPersonal
        {
            get => Documento;
            set => Documento = value;
        }
        public string ApellidoPersonal
        {
            get => Apellido;
            set => Apellido = value;
        }
        public string NombrePersonal
        {
            get => Nombre;
            set => Nombre = value;
        }
        public DateTime FechaIngresoPersonal
        {
            get => FechaIngreso;
            set => FechaIngreso = value;
        }
        public DateTime FechaEgresoPersonal
        {
            get => FechaEgreso;
            set => FechaEgreso = value;
        }
        public int UsuarioPersonal
        {
            get => Usuario;
            set => Usuario = value;
        }
        public int MotivoEgresoPersonal
        {
            get => MotivoEgreso;
            set => MotivoEgreso = value;
        }

        public int IdBarrioPersonal
        {
            get => IdBarrio;
            set => IdBarrio = value;
        }
        public string CallePersonal
        {
            get => Calle;
            set => Calle = value;
        }
        public int NroCallePersonal
        {
            get => NroCalle;
            set => NroCalle = value;
        }
        public DateTime FecNacimientoPersonal
        {
            get => FecNacimiento;
            set => FecNacimiento = value;
        }
        public int CodigoProyectoPersonal
        {
            get => CodigoProyecto;
            set => CodigoProyecto = value;
        }
    }
}
