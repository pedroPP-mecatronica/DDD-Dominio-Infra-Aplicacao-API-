using Eloja_Api.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eloja_Api.Dominio.DTOs
{
    public class BaseCategoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public EnumSituacao Situacao { get; set; }
    }
}
