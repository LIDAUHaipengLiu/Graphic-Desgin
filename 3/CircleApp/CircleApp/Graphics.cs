//author:Haipeng Liu
//License(GPL v3)
//https://github.com/LIDAUHaipengLiu/Graphic-Desgin
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics {
    abstract class Graphics {
        public static int graphicsquantity = 0;

        public Graphics() {
            graphicsquantity = graphicsquantity + 1;
        }//func Graphics

        ~Graphics() {
            graphicsquantity = graphicsquantity - 1;
        }//func ~Graphics

        public static int get_graphicsQuantity() {
            return graphicsquantity;
        }//func get_quantity

        public abstract void set_name(string namevalue);
        public abstract void set_position(int[] positionvalue);
        public abstract void set_angle(int anglevalue);
        public abstract int get_id();
        public abstract string get_name();
        public abstract string get_typeOf();
        public abstract int[] get_position();
        public abstract int get_angle();
        public abstract double get_area();
        public abstract double get_perimeter();
    }//class Graphics
}//namespace CircleApp