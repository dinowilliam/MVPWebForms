using System;
using System.Web.UI;

namespace MVPWebForms {

    using MVPWebForms.MVP.Presenters;
    using MVPWebForms.MVP.Views;

    public partial class _Default : Page, IDefaultView {

        DefaultPresenter _defaultPresenter; 

        protected void Page_Load(object sender, EventArgs e) {
            _defaultPresenter = new DefaultPresenter(this);            
        }

        protected void btnResult_Click(object sender, EventArgs e) {
            _defaultPresenter.CalculateAreaCircle();
        }

        public string Radius { 
            get => txtRadius.Text; 
            set => txtRadius.Text = value; 
        }

        public string Area { 
            get => lblArea.Text; 
            set => lblArea.Text = value; 
        }

        
    }
}