using NetZ.Web.Html;
using NetZ.Web.Html.Componente;
using NetZ.Web.Html.Componente.Botao;
using NetZ.Web.Server.Arquivo.Css;

namespace XPlaneWeb.Html.Componente.Controle
{
    public abstract class ControleBase : ComponenteHtml
    {
        #region Constantes

        #endregion Constantes

        #region Atributos

        private BotaoCircular _btnFechar;
        private Div _divConteudo;
        private Div _divTitulo;
        private Div _divValor;

        protected Div divConteudo
        {
            get
            {
                if (_divConteudo != null)
                {
                    return _divConteudo;
                }

                _divConteudo = new Div();

                return _divConteudo;
            }
        }

        private BotaoCircular btnFechar
        {
            get
            {
                if (_btnFechar != null)
                {
                    return _btnFechar;
                }

                _btnFechar = new BotaoCircular();

                return _btnFechar;
            }
        }

        private Div divTitulo
        {
            get
            {
                if (_divTitulo != null)
                {
                    return _divTitulo;
                }

                _divTitulo = new Div();

                return _divTitulo;
            }
        }

        private Div divValor
        {
            get
            {
                if (_divValor != null)
                {
                    return _divValor;
                }

                _divValor = new Div();

                return _divValor;
            }
        }

        #endregion Atributos

        #region Construtores

        #endregion Construtores

        #region Métodos

        protected override void inicializar()
        {
            base.inicializar();

            this.btnFechar.strConteudo = "X";

            this.divTitulo.strConteudo = "Acelerador";

            this.divValor.strConteudo = "100 %";
        }

        protected override void montarLayout()
        {
            base.montarLayout();

            this.btnFechar.setPai(this);

            this.divTitulo.setPai(this);

            this.divValor.setPai(this);

            this.divConteudo.setPai(this);
        }

        protected override void setCss(CssArquivo css)
        {
            base.setCss(css);

            this.addCss(css.setBackgroundColor("#f8f8f8"));
            this.addCss(css.setBorder(1, "solid", "#dadada"));
            this.addCss(css.setBottom(10));
            this.addCss(css.setBoxShadow(0, 0, 5, 0, "gray"));
            this.addCss(css.setLeft(10));
            this.addCss(css.setPosition("absolute"));
            this.addCss(css.setRight(10));
            this.addCss(css.setTextAlign("center"));
            this.addCss(css.setTop(10));

            this.btnFechar.addCss(css.setBackgroundColor("#F44336"));
            this.btnFechar.addCss(css.setColor("#752e29"));
            this.btnFechar.addCss(css.setFontSize(25));
            this.btnFechar.addCss(css.setPosition("absolute"));
            this.btnFechar.addCss(css.setRight(10));
            this.btnFechar.addCss(css.setTop(10));

            this.divConteudo.addCss(css.setBottom(25));
            this.divConteudo.addCss(css.setLeft(25));
            this.divConteudo.addCss(css.setPosition("absolute"));
            this.divConteudo.addCss(css.setRight(25));
            this.divConteudo.addCss(css.setTop(100));

            this.divTitulo.addCss(css.setFontSize(25));
            this.divTitulo.addCss(css.setPaddingTop(20));

            this.divValor.addCss(css.setFontSize(20));
        }

        #endregion Métodos

        #region Eventos

        #endregion Eventos
    }
}