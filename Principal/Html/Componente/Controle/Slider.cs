using NetZ.Web.Html;
using NetZ.Web.Server.Arquivo.Css;

namespace XPlaneWeb.Html.Componente.Controle
{
    public class Slider : ControleBase
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private Div _divAlavanca;
        private Div _divTrilha;

        private Div divAlavanca
        {
            get
            {
                if (_divAlavanca != null)
                {
                    return _divAlavanca;
                }

                _divAlavanca = new Div();

                return _divAlavanca;
            }
        }

        private Div divTrilha
        {
            get
            {
                if (_divTrilha != null)
                {
                    return _divTrilha;
                }

                _divTrilha = new Div();

                return _divTrilha;
            }
        }

        #endregion Atributos

        #region Construtores

        #endregion Construtores

        #region Métodos

        protected override void montarLayout()
        {
            base.montarLayout();

            this.divTrilha.setPai(this.divConteudo);

            this.divAlavanca.setPai(this.divTrilha);
        }

        protected override void setCss(CssArquivo css)
        {
            base.setCss(css);

            this.divAlavanca.addCss(css.setBackgroundColor("#2196F3"));
            this.divAlavanca.addCss(css.setBorderRadius(25));
            this.divAlavanca.addCss(css.setHeight(50));
            this.divAlavanca.addCss(css.setLeft(-125));
            this.divAlavanca.addCss(css.setPosition("absolute"));
            this.divAlavanca.addCss(css.setWidth(250));

            this.divTrilha.addCss(css.setBackgroundColor("#1168ac"));
            this.divTrilha.addCss(css.setBorderRadius(5));
            this.divTrilha.addCss(css.setHeight(100, "%"));
            this.divTrilha.addCss(css.setMargin("auto"));
            this.divTrilha.addCss(css.setPosition("relative"));
            this.divTrilha.addCss(css.setWidth(10));
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}