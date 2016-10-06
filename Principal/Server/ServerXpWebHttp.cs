using NetZ.Web.Server;

namespace XPlaneWeb.Server
{
    public class ServerXpWebHttp : ServerHttp
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static ServerXpWebHttp _i;

        public static ServerXpWebHttp i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new ServerXpWebHttp();

                return _i;
            }
        }

        #endregion Atributos

        #region Construtores

        private ServerXpWebHttp() : base(Properties.Resources.server_xp_web_http_nome)
        {
        }

        #endregion Construtores

        #region Métodos

        public override Resposta responder(Solicitacao objSolicitacao)
        {
            Resposta objResposta = base.responder(objSolicitacao);

            if (objResposta != null)
            {
                return objResposta;
            }

            return new Resposta(objSolicitacao).addHtml(new Html.Pagina.PagPrincipal());
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}