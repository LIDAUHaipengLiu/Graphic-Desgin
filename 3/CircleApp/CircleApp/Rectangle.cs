//author:Haipeng Liu
//License(GPL v3)
//https://github.com/LIDAUHaipengLiu/Graphic-Desginusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics{
    class Rectangle : Graphics {
        private static int rectanglequantity = 0;
        private int id;
        private string name;
        private const string type = "Rectangle";
        private int[] position;
        private int angle;
        private int bottom;
        private int height;

        public Rectangle() {
            id = graphicsquantity;

            rectanglequantity = rectanglequantity + 1;
        }//func Rectangle

        ~Rectangle() {
            rectanglequantity = rectanglequantity - 1;
        }//func Rectangle

        public override void set_name(string namevalue){
            name = namevalue;
        }//func set_name

        public override void set_position(int[] positionvalue){
            position = positionvalue;
        }//func set_position

        public override void set_angle(int anglevalue){
            angle = anglevalue;
        }//func set_angle

        public void set_bottom(int bottomvalue) {
            bottom = bottomvalue;
        }//func set_bottom

        public void set_height(int heightvalue) {
            height = heightvalue;
        }//func set_bottom

        public static int get_rectangleQuantity() {
            return rectanglequantity;
        }//func get_typeQuantity

        public override int get_id() {
            return id;
        }//func get_id

        public override string get_name() {
            return name;
        }//func get_name

        public override string get_typeOf() {
            return type;
        }//func get_typeOf

        public override int[] get_position() {
            return position;
        }//func get_position

        public override int get_angle() {
            return angle;
        }//func get_angle

        public int get_bottom() {
            return bottom;
        }//func set_bottom

        public int get_height() {
            return height;
        }//func set_bottom

        public override double get_area() {
            return bottom * height;
        }//func get_area

        public override double get_perimeter() {
            return 2 * (bottom + height);
        }//func get_perimeter
    }//class Rectangle
}//namespace 
