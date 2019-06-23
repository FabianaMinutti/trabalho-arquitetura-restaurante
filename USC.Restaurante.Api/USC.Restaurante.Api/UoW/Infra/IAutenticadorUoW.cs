using USC.Restaurante.BLL.Infra;

namespace USC.Restaurante.Api.UoW.Infra
{
    public interface IAutenticadorUoW
    {
        IAutenticadorBLL autenticadorBLL { get; }
    }
}
