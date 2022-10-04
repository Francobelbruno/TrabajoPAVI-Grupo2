using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPAV1.Entidades
{
    internal class EtapaXProyecto
    {
        private int CodProducto;
        private string IdEtapa;
        private DateTime FechaInicio;
        private DateTime FechaFin;

        public EtapaXProyecto()
        {

        }



        public int CodProductoEtapaXProyecto
        {
            get => CodProducto;
            set => CodProducto = value;
        }

        public string IdEtapaXProyecto
        {
            get => IdEtapa;
            set => IdEtapa = value;
        }

        public DateTime FechaInicioEtapaXProyecto
        {
            get => FechaInicio;
            set => FechaInicio = value;
        }

        public DateTime FechaFinEtapaXProyecto
        {
            get => FechaFin;
            set => FechaFin = value;
        }


    }
}
