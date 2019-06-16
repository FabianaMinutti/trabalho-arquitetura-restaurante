using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using USC.Restaurante.Interfaces;

namespace USC.Restaurante.Entities
{
    /// <summary>
    /// Entidade Pessoa
    /// </summary>
    [Table("PESSOA")]
    public class Pessoa : IEntity
    {
        /// <summary>
        /// Identificador de Pessoa
        /// </summary>
        [Key]
        public long IdPessoa { get; set; }
        /// <summary>
        /// Propriedade Nome
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Propriedade Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Propriedade CpfCnpj
        /// </summary>
        public string CpfCnpj { get; set; }

        /// <summary>
        /// Método responsável por validar a entidade
        /// </summary>
        /// <returns>
        /// True se entidade válida
        /// False se entidade inválida
        /// </returns>
        public bool ValidarEntidade()
        {
            return IdPessoa != default(long)
                && !string.IsNullOrEmpty(Nome) && Nome.Length <= 120
                && !string.IsNullOrEmpty(Email) && Email.Length <= 120
                && !string.IsNullOrEmpty(CpfCnpj) && CpfCnpj.Length <= 14;
        }

        /// <summary>
        /// Verifica mensagens de erro retornadas
        /// </summary>
        /// <returns>Caso houver, as mensagens de erro</returns>
        public IEnumerable<string> VerificarMensagens()
        {
            if (IdPessoa == default(long))
                yield return "Identificador Pessoa inválido.";

            if (string.IsNullOrEmpty(Nome) || Nome.Length > 120)
                yield return "Nome inválido.";

            if (string.IsNullOrEmpty(Email) || Email.Length > 120)
                yield return "E-mail inválido.";

            if (string.IsNullOrEmpty(CpfCnpj) || CpfCnpj.Length > 14)
                yield return "CPF/CNPJ inválido.";
        }
    }
}
