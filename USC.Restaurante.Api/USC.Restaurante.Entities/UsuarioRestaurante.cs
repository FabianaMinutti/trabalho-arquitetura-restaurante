using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using USC.Restaurante.Interfaces;

namespace USC.Restaurante.Entities
{
    /// <summary>
    /// Entidade responsável pela tabela de UsuarioRestaurante
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
        /// Identificador de Usuario
        /// </summary>
        [ForeignKey("IdUsuario")]
        public long IdUsuario { get; set; }

        /// <summary>
        /// Identificador de Restaurante
        /// </summary>
        [ForeignKey("IdRestaurante")]
        public long IdRestaurante { get; set; }

        /// <summary>
        /// Data hora da inclusão do registro
        /// </summary>
        public DateTime DataHoraInclusao { get; set; }

        /// <summary>
        /// Método responsável por verificar se a entidade é válida
        /// </summary>
        /// <returns>True se entidade válida e false se entidade com algum valor incorreto</returns>
        public bool ValidarEntidade()
        {
            return
                IdUsuarioRestaurante != 0 &&
                IdUsuario != 0 &&
                IdRestaurante != 0;
        }
    }
}
