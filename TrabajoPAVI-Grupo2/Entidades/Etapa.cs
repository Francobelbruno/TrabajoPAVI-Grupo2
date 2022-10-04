using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPAV1.Entidades
{
    internal class Etapa
    {

        private string Id;
        private string Descripcion;

        public Etapa(string id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }

        public Etapa()
        {

        }

        public string IdEtapa
        {
            get => Id;
            set => Id = value;
        }

        public string DescripcionEtapa
        {
            get => Descripcion;
            set => Descripcion = value;
        }
    }

}
