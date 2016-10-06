using System;
using System.Collections.Generic;
using NetZ.Web;
using NetZ.Web.Server;

namespace XPlaneWeb
{
    public sealed class AppXpWeb : AppWeb
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private static AppXpWeb _i;

        public new static AppXpWeb i
        {
            get
            {
                if (_i != null)
                {
                    return _i;
                }

                _i = new AppXpWeb();

                return _i;
            }
        }

        #endregion Atributos

        #region Construtores

        private AppXpWeb() : base("X-Plane Web")
        {
        }

        #endregion Construtores

        #region Métodos

        protected override ConfigWeb getObjConfig()
        {
            return XpWebConfig.i;
        }

        protected override void inicializarLstSrv(List<ServerBase> lstSrv)
        {
            lstSrv.Add(Server.ServerXpWebHttp.i);
            lstSrv.Add(Server.ServerXpWebWs.i);
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}