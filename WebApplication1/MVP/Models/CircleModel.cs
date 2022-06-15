using MVPWebForms.MVP.Models.Contracts;
using System;

namespace MVPWebForms.MVP.Models {
    
    public class CircleModel : ICircleModel {
        
        public CircleModel() { }

        public double getArea(double radius) {
            return Math.PI * radius * radius;
        }
    }

}