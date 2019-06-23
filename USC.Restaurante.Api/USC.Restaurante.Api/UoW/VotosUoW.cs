using USC.Restaurante.Api.UoW.Infra;
using USC.Restaurante.BLL.Infra;

namespace USC.Restaurante.Api.UoW
{
    public class VotosUoW : IVotosUoW
    {
        public IVotosBLL votosBLL { get; }

        public VotosUoW(IVotosBLL votosBLL)
        {
            this.votosBLL = votosBLL;
        }
    }
}
