using XPlaneWeb.Html.Componente.Controle;

namespace XPlaneWeb.Html.Pagina
{
    public class PagPrincipal : PagXpWebBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        #endregion Atributos

        #region Construtores

        public PagPrincipal() : base("Principal")
        {
        }

        #endregion Construtores

        #region Métodos

        protected override void montarLayout()
        {
            base.montarLayout();

            new Slider().setPai(this);
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}