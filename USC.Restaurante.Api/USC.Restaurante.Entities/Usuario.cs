using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using USC.Restaurante.Interfaces;

namespace USC.Restaurante.Entities
{
    /// <summary>
    /// Entidade responsável pela tabela de Usuário
    /// </summary>
    [Table("USUARIO")]
    public class Usuario : IEntity
    {
        /// <summary>
        /// Identificador de login
        /// </summary>
        [Key]
        public long IdLogin { get; set; }

        /// <summary>
        /// Login do usuário
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Senha do usuário
        /// </summary>
        public string Senha { get; set; }

        /// <summary>
        /// Método responsável por verificar se a entidade é válida
        /// </summary>
        /// <returns>True se entidade válida e false se entidade com algum valor incorreto</returns>
        public bool ValidarEntidade()
        {
            return
                IdLogin != 0 &&
                !(string.IsNullOrEmpty(Login)) &&
                !(string.IsNullOrEmpty(Senha));
        }
    }
}
