using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using USC.Restaurante.Interfaces;

namespace USC.Restaurante.Entities
{
    /// <summary>
    /// Entidade UsuarioRestaurante
    /// </summary>
    [Table("USUARIORESTAURANTE")]
    public class UsuarioRestaurante : IEntity
    {
        /// <summary>
        /// Identificador de UsuarioRestaurante
        /// </summary>
        [Key]
        public long IdUsuarioRestaurante { get; set; }
        /// <summary>
        /// Identificador de Restaurante
        /// </summary>
        [ForeignKey("IdRestaurante")]
        public long IdRestaurante { get; set; }
        /// <summary>
        /// Identificador de Usuario
        /// </summary>
        [ForeignKey("IdUsuario")]
        public long IdUsuario { get; set; }
        /// <summary>
        /// Propriedade DataHora
        /// </summary>
        public DateTime DataHora { get; set; }
        /// <summary>
        /// Propriedade Restaurante
        /// </summary>
        public virtual Restaurante Restaurante { get; set; }
        /// <summary>
        /// Propriedade Usuario
        /// </summary>
        public virtual Usuario Usuario { get; set; }

        /// <summary>
        /// Método responsável por validar a entidade
        /// </summary>
        /// <returns>
        /// True se entidade válida
        /// False se entidade inválida
        /// </returns>
        public bool ValidarEntidade()
        {
            return IdUsuarioRestaurante != default(long)
                && IdRestaurante != default(long)
                && IdUsuario != default(long);
        }

        /// <summary>
        /// Verifica mensagens de erro retornadas
        /// </summary>
        /// <returns>Caso houver, as mensagens de erro</returns>
        public IEnumerable<string> VerificarMensagens()
        {
            if (IdUsuarioRestaurante == default(long))
                yield return "Identificador UsuarioRestaurante inválido.";

            if (IdRestaurante == default(long))
                yield return "Identificador Restaurante inválido.";

            if (IdUsuario == default(long))
                yield return "Identificador Usuario inválido.";
        }
    }
}
