//author:Haipeng Liu
//License(GPL v3)
//https://github.com/LIDAUHaipengLiu/Graphic-Desgin
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics{
    class Circle : Graphics {
        private static int circlequantity = 0;
        private int id;
        private string name;
        private const string type = "Circle";
        private int[] position;
        private int angle;
        private int radius;

        public Circle() {
            id = graphicsquantity;
            this.set_name("Circle" + id);
            this.set_position(new int[] {0, 0});
            this.set_angle(0);
            this.set_radius(1);
            circlequantity = circlequantity + 1;
        }//func Circle

        public Circle(string namevalue) {
            id = graphicsquantity;
            this.set_name(namevalue);
            this.set_position(new int[] { 0, 0 });
            this.set_angle(0);
            this.set_radius(1);
            circlequantity = circlequantity + 1;
        }//func Circle

        public Circle(string namevalue, int[] positionvalue, int anglevalue,
                      int radiusvalue) {
            id = graphicsquantity;
            this.set_name(namevalue);
            this.set_position(positionvalue);
            this.set_angle(anglevalue);
            this.set_radius(radiusvalue);
            circlequantity = circlequantity + 1;
        }//func Circle

        ~Circle() {
            circlequantity = circlequantity - 1;
        }//func ~Circle

        public override void set_name(string namevalue){
            name = namevalue;
        }//func set_name

        public override void set_position(int[] positionvalue){
            position = positionvalue;
        }//func set_position

        public override void set_angle(int anglevalue){

        }//func set_angle

        public void set_radius(int radiusvalue){
            radius = radiusvalue;
        }//func set_radius

        public static int get_circleQuantity(){
            return circlequantity;
        }//func get_typeQuantity

        public override int get_id(){
            return id;
        }//func get_id

        public override string get_name(){
            return name;
        }//func get_name

        public override string get_typeOf(){
            return type;
        }//func get_typeOf

        public override int[] get_position() {
            return position;
        }//func get_position

        public override int get_angle() {
            return angle;
        }//func get_angle

        public int get_radius() {
            return radius;
        }//func get_radius

        public override double get_area(){
            return Math.PI * radius * radius;
        }//func get_area

        public override double get_perimeter(){
            return Math.PI * 2 * radius;
        }//func get_perimeter
    }//class Circle : Graphics
}//namespace CircleApp