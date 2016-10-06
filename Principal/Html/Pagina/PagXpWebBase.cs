using NetZ.Web.Html.Componente;
using NetZ.Web.Html.Pagina;

namespace XPlaneWeb.Html.Pagina
{
    public abstract class PagXpWebBase : PagMobile
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private ActionBar _divActionBar;

        private ActionBar divActionBar
        {
            get
            {
                if (_divActionBar != null)
                {
                    return _divActionBar;
                }

                _divActionBar = new ActionBar();

                return _divActionBar;
            }
        }

        #endregion Atributos

        #region Construtores

        public PagXpWebBase(string strNome) : base(strNome)
        {
        }

        #endregion Construtores

        #region Métodos

        protected override void montarLayout()
        {
            base.montarLayout();

            this.divActionBar.setPai(this);
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}