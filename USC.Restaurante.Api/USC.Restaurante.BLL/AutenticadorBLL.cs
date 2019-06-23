using System.Threading.Tasks;
using USC.Restaurante.BLL.Infra;
using USC.Restaurante.DAL.Infra;
using USC.Restaurante.Entities;
using USC.Restaurante.Erros;

namespace USC.Restaurante.BLL
{
    public class AutenticadorBLL : IAutenticadorBLL
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public AutenticadorBLL(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Task<Usuario> PostAutenticaAsync(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Login))
                throw new ParametroInvalidoException("Login não preenchido.", "Login");

            if (string.IsNullOrEmpty(usuario.Senha))
                throw new ParametroInvalidoException("Senha não preenchida.", "Senha");

            var usuarioExistente = _usuarioRepository.GetUsuarioByLoginAsync(usuario.Login);

            if (usuarioExistente == null)
                throw new ElementoNaoEncontratoException("Usuário não encontrado");

            if (usuario.Senha == usuarioExistente.Result.Senha)
                return usuarioExistente;
            else
                throw new ParametroInvalidoException("Senha inválida.", "Senha");
        }
    }
}
