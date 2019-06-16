using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using USC.Restaurante.Entities.Enum;
using USC.Restaurante.Interfaces;

namespace USC.Restaurante.Entities
{
    /// <summary>
    /// Entidade Usuario
    /// </summary>
    [Table("USUARIO")]
    public class Usuario : IEntity
    {
        /// <summary>
        /// Identificador de Usuário
        /// </summary>
        [Key]
        public long IdUsuario { get; set; }
        /// <summary>
        /// Propriedade Login
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Propriedade Senha
        /// </summary>
        public string Senha { get; set; }
        /// <summary>
        /// Propriedade TipoPessoa
        /// </summary>
        public EnumTipoPessoa TipoPessoa { get; set; }
        /// <summary>
        /// Identificador de Pessoa
        /// </summary>
        [ForeignKey("IdPessoa")]
        public long IdPessoa { get; set; }
        /// <summary>
        /// Propriedade Pessoa
        /// </summary>
        public virtual Pessoa Pessoa { get; set; }

        /// <summary>
        /// Método responsável por validar a entidade
        /// </summary>
        /// <returns>
        /// True se entidade válida
        /// False se entidade inválida
        /// </returns>
        public bool ValidarEntidade()
        {
            return IdUsuario != default(long)
                && IdPessoa != default(long)
                && !string.IsNullOrEmpty(Login) && Login.Length <= 60
                && !string.IsNullOrEmpty(Senha) && Senha.Length <= 60;
        }

        /// <summary>
        /// Verifica mensagens de erro retornadas
        /// </summary>
        /// <returns>Caso houver, as mensagens de erro</returns>
        public IEnumerable<string> VerificarMensagens()
        {
            if (IdUsuario == default(long))
                yield return "Identificador Usuário inválido.";

            if (IdPessoa == default(long))
                yield return "Identificador Pessoa inválido.";

            if (string.IsNullOrEmpty(Login) || Login.Length > 60)
                yield return "Login inválido.";

            if (string.IsNullOrEmpty(Senha) || Senha.Length > 60)
                yield return "Senha inválida.";
        }
    }
}
