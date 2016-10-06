using NetZ.Web.Server.WebSocket;

namespace XPlaneWeb.Server
{
    public class ServerXpWebWs : ServerWs // TODO: Renomear para ServerWebSocket
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static ServerXpWebWs _i;

        public static ServerXpWebWs i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new ServerXpWebWs();

                return _i;
            }
        }

        #endregion Atributos

        #region Construtores

        private ServerXpWebWs() : base(Properties.Resources.server_xp_web_ws_nome)
        {
        }

        #endregion Construtores

        #region Métodos

        protected override int getIntPort()
        {
            return 443; // TODO: Tornar o método virtual e não obrigatório.
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}