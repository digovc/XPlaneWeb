using NetZ.Web;

namespace XPlaneWeb
{
    internal class XpWebConfig : ConfigWeb
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static XpWebConfig _i;

        public new static XpWebConfig i // TODO: Remover o i do ConfigWeb
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new XpWebConfig();

                return _i;
            }
        }

        #endregion Atributos

        #region Construtores

        private XpWebConfig()
        {
        }

        #endregion Construtores

        #region Métodos

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}