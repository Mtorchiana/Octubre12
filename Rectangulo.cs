using System;

namespace Classes{
     public class Rectangulo:Figura{
        public Rectangulo(int b, int a){
            this.Base = b;
            this.Altura = a;
        }
        public int Base{get;set;}
         public int Altura{get;set;}
        public override int getArea() => this.Base * this.Altura;

    }
}