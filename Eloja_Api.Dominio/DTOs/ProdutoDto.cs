using Eloja_Api.Dominio.Entidades;
using Eloja_Api.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eloja_Api.Dominio.DTOs
{
    public class ProdutoDto : BaseProdutoDto
    {
        public virtual BaseCategoriaDto Categoria { get; set; }
    }
}
