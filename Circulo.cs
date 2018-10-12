using System;

namespace Classes{
     public class Circulo: Figura{
         private int Radio{get;set;}
        public Circulo(int r) => this.Radio = r;
        public override int getArea() => this.Radio * this.Radio;


    }
}