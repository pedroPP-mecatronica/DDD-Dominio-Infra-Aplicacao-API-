using Eloja_Api.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eloja_Api.Dominio.Entidades
{
     
        public class Categoria
        {
            public int Id { get; private set; }

            public string Nome { get; private set; }

            public EnumSituacao Situacao { get; private set; }

            public List<Produto> Produtos { get; private set; }


            public Categoria(int id, string nome, EnumSituacao situacao)
            {
                Id = id;
                Nome = nome;
                Situacao = situacao;
            }

            public void Atualizar(string nome, EnumSituacao situacao)
            {
                Nome = nome;
                Situacao = situacao;
            }

            public bool IsTemProdutos() => Produtos.Any();

            public string ObterSituacao()
            {
                if (Situacao == EnumSituacao.Ativo)
                    return "Ativo";

                return "Inativo";
            }

            public override string ToString()
            {
                return $"Id: {Id}, Nome: {Nome}, Situacao: {ObterSituacao()}";
            }
        
    }
}
