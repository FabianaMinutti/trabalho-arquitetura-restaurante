using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using USC.Restaurante.Interfaces;

namespace USC.Restaurante.Entities
{
    /// <summary>
    /// Entidade responsável pela tabela de RestauranteEscolhidoHistorico
    /// </summary>
    [Table("RESTAURANTEESCOLHIDOHISTORICO")]
    public class RestauranteEscolhidoHistorico : IEntity
    {
        /// <summary>
        /// Identificador de RestauranteEscolhidoHistorico
        /// </summary>
        [Key]
        public long IdRestauranteEscolhidoHistorico { get; set; }

        /// <summary>
        /// Identificador de Restaurante
        /// </summary>
        [ForeignKey("IdRestaurante")]
        public long IdRestaurante { get; set; }
        
        /// <summary>
        /// Data/Hora que restaurante foi escolhido
        /// </summary>
        public DateTime DataHoraEscolha { get; set; }

        /// <summary>
        /// Quantidade de votos
        /// </summary>
        public int QuantidadeVotos { get; set; }

        /// <summary>
        /// Observação sobre o restaurante escolhido
        /// </summary>
        public string Observacao { get; set; }

        /// <summary>
        /// Método responsável por verificar se a entidade é válida
        /// </summary>
        /// <returns>True se entidade válida e false se entidade com algum valor incorreto</returns>
        public bool ValidarEntidade()
        {
            return
                IdRestauranteEscolhidoHistorico != 0 &&
                IdRestaurante != 0 &&
                QuantidadeVotos != -1;
        }
    }
}
