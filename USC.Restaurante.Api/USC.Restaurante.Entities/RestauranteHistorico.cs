using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using USC.Restaurante.Interfaces;

namespace USC.Restaurante.Entities
{
    /// <summary>
    /// Entidade UsuarioRestauranteHistorico
    /// </summary>
    [Table("RESTAURANTEHISTORICO")]
    public class RestauranteHistorico : IEntity
    {
        /// <summary>
        /// Identificador de UsuarioRestauranteHistorico
        /// </summary>
        [Key]
        public long IdRestauranteHist { get; set; }
        /// <summary>
        /// Identificador de Restaurante
        /// </summary>
        [ForeignKey("IdRestaurante")]
        public long IdRestaurante { get; set; }
        /// <summary>
        /// Propriedade DataHoraEscolha
        /// </summary>
        public DateTime DataHoraEscolha { get; set; }
        /// <summary>
        /// Propriedade QuantidadeVotos
        /// </summary>
        public int QuantidadeVotos { get; set; }
        /// <summary>
        /// Propriedade Restaurante
        /// </summary>
        public virtual Restaurante Restaurante { get; set; }

        /// <summary>
        /// Método responsável por validar a entidade
        /// </summary>
        /// <returns>
        /// True se entidade válida
        /// False se entidade inválida
        /// </returns>
        public bool ValidarEntidade()
        {
            return IdRestauranteHist != default(long)
                && IdRestaurante != default(long)
                && QuantidadeVotos > 0;
        }

        /// <summary>
        /// Verifica mensagens de erro retornadas
        /// </summary>
        /// <returns>Caso houver, as mensagens de erro</returns>
        public IEnumerable<string> VerificarMensagens()
        {
            if (IdRestauranteHist == default(long))
                yield return "Identificador RestauranteHistorico inválido.";

            if (IdRestaurante == default(long))
                yield return "Identificador Restaurante inválido.";

            if (QuantidadeVotos < 1)
                yield return "Quantidade de votos inválidos.";
        }
    }
}
