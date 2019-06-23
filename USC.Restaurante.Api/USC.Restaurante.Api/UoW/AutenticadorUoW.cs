using USC.Restaurante.Api.UoW.Infra;
using USC.Restaurante.BLL.Infra;

namespace USC.Restaurante.Api.UoW
{
    public class AutenticadorUoW : IAutenticadorUoW
    {
        public IAutenticadorBLL autenticadorBLL { get; }

        public AutenticadorUoW(IAutenticadorBLL autenticadorBLL)
        {
            this.autenticadorBLL = autenticadorBLL;
        }
    }
}
