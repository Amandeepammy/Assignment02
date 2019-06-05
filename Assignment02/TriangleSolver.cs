using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public static class TriangleSolver
    {
        public static string Analyze(int first_side, int second_side, int third_side)
        {            
            string return_string=string.Empty;
            int largest=0;

            if (first_side > second_side)
            {
                if (first_side > third_side)
                {
                    largest = first_side;
                }
                else
                {
                    largest = third_side;
                }
            }
            else if(second_side > third_side)
            {
                largest = second_side;
            }
            else
            {
                largest = third_side;
            }

            int sum_of_all_sides = first_side + second_side + third_side;
            int sum_of_two_smaller_sides = sum_of_all_sides - largest;
            string triangle_type = string.Empty;
            string triangle = string.Empty;

            if(sum_of_two_smaller_sides > largest)
            {
                triangle = "The input sides do form a Triangle\n";

                if((first_side==second_side) && (second_side==third_side))
                {
                    triangle_type = " And the formed Triangle is Equilateral\n";
                }
                else if((first_side!=second_side) && (first_side!=third_side) && (second_side != third_side))
                {
                    triangle_type = " And the formed Triangle is Scalene\n";
                }
                else
                {
                    triangle_type = " And the formed Triangle is Isosceles\n";
                }

                return_string = triangle + triangle_type;
            }
            else
            {
                return_string = "The input sides do not form any Triangle\n";
            }

            return return_string;
        }
    }
}
