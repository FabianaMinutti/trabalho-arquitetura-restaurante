using USC.Restaurante.BLL.Infra;

namespace USC.Restaurante.Api.UoW.Infra
{
    public interface IUsuarioUoW
    {
        IUsuarioBLL usuarioBLL { get; }
    }
}
