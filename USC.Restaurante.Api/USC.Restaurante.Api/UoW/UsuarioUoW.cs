using USC.Restaurante.Api.UoW.Infra;
using USC.Restaurante.BLL.Infra;

namespace USC.Restaurante.Api.UoW
{
    public class UsuarioUoW : IUsuarioUoW
    {
        public IUsuarioBLL usuarioBLL { get; }

        public UsuarioUoW(IUsuarioBLL usuarioBLL)
        {
            this.usuarioBLL = usuarioBLL;
        }
    }
}
