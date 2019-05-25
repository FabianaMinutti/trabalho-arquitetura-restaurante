using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using USC.Restaurante.Entities.Enum;
using USC.Restaurante.Interfaces;

namespace USC.Restaurante.Entities
{
    /// <summary>
    /// Entidade responsável pela tabela de Restaurante
    /// </summary>
    [Table("RESTAURANTE")]
    public class Restaurante : IEntity
    {
        /// <summary>
        /// Identificador de restaurante
        /// </summary>
        [Key]
        public long IdRestaurante { get; set; }

        /// <summary>
        /// Nome do restaurante
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Categoria do restaurante
        /// </summary>
        public EnumCategoriaRestaurante Categoria { get; set; }

        /// <summary>
        /// Endereço do restaurante
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Bairro do restaurante
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Cidade do restaurante
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// UF do restaurante
        /// </summary>
        public string UF { get; set; }

        /// <summary>
        /// Método responsável por verificar se a entidade é válida
        /// </summary>
        /// <returns>True se entidade válida e false se entidade com algum valor incorreto</returns>
        public bool ValidarEntidade()
        {
            return IdRestaurante != 0 &&
                   !(string.IsNullOrEmpty(Nome)) &&
                   !(string.IsNullOrEmpty(Endereco)) &&
                   !(string.IsNullOrEmpty(Bairro)) &&
                   !(string.IsNullOrEmpty(Cidade)) &&
                   !(string.IsNullOrEmpty(UF)) &&
                   !(UF.Length != 2);
        }
    }
}
