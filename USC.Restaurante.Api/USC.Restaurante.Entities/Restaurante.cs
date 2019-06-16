using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using USC.Restaurante.Entities.Enum;
using USC.Restaurante.Interfaces;

namespace USC.Restaurante.Entities
{
    /// <summary>
    /// Entidade Restaurante
    /// </summary>
    [Table("RESTAURANTE")]
    public class Restaurante : IEntity
    {
        /// <summary>
        /// Identificador de Restaurante
        /// </summary>
        [Key]
        public long IdRestaurante { get; set; }
        /// <summary>
        /// Propriedade Nome
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Propriedade Categoria
        /// </summary>
        public EnumCategoriaRestaurante Categoria { get; set; }
        /// <summary>
        /// Propriedade Bairro
        /// </summary>
        public string Bairro { get; set; }
        /// <summary>
        /// Propriedade Cidade
        /// </summary>
        public string Cidade { get; set; }
        /// <summary>
        /// Propriedade UF
        /// </summary>
        public string UF { get; set; }

        /// <summary>
        /// Método responsável por validar a entidade
        /// </summary>
        /// <returns>
        /// True se entidade válida
        /// False se entidade inválida
        /// </returns>
        public bool ValidarEntidade()
        {
            return IdRestaurante != default(long)
                && !string.IsNullOrEmpty(Nome) && Nome.Length <= 120
                && !string.IsNullOrEmpty(Bairro) && Bairro.Length <= 60
                && !string.IsNullOrEmpty(Cidade) && Cidade.Length <= 60
                && !string.IsNullOrEmpty(UF) && UF.Length == 2;
        }

        /// <summary>
        /// Verifica mensagens de erro retornadas
        /// </summary>
        /// <returns>Caso houver, as mensagens de erro</returns>
        public IEnumerable<string> VerificarMensagens()
        {
            if (IdRestaurante == default(long))
                yield return "Identificador Restaurante inválido.";

            if (string.IsNullOrEmpty(Nome) || Nome.Length > 120)
                yield return "Nome inválido.";

            if (string.IsNullOrEmpty(Bairro) || Bairro.Length > 60)
                yield return "Bairro inválido.";

            if (string.IsNullOrEmpty(Cidade) || Cidade.Length > 60)
                yield return "Cidade inválida.";

            if (string.IsNullOrEmpty(UF) || UF.Length > 2 || UF.Length < 2)
                yield return "UF inválida.";
        }
    }
}
