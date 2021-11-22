using Eloja_Api.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eloja_Api.Dominio.DTOs
{
    public class BaseProdutoDto
    {
        public int Id { get; set; }

        public int CategoriaId { get; set; }

        public string Nome { get; set; }

        public int QtdEstoque { get; set; }

        public int QtdEstoqueMinimo { get; set; }

        public decimal Valor { get; set; }

        public decimal ValorPromocao { get; set; }

        public EnumSituacao Situacao { get; set; }
    }
}
