using System;

namespace MVPWebForms.MVP.Presenters {
    
    using MVPWebForms.MVP.Models;
    using MVPWebForms.MVP.Views;

    public class DefaultPresenter {

        IDefaultView _defaultView;
        CircleModel _model;

        public DefaultPresenter(IDefaultView defaultView) {
            _defaultView = defaultView;
            _model = new CircleModel();
        }

        public double CalculateAreaCircle() {
            
            _defaultView.Area = _model.getArea(double.Parse(_defaultView.Radius)).ToString();
            return Convert.ToDouble(_defaultView.Area);
        }

    }
}