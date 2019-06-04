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
            string triangle_type = string.Empty;
            string triangle = string.Empty;

            if(((first_side + second_side) > third_side) && ((first_side + third_side) > second_side) && ((second_side + third_side) > first_side))
            {
                triangle = "The input sides do form a Triangle";

                if((first_side==second_side) && (second_side==third_side))
                {
                    triangle_type = " And the formed Triangle is Equilateral";
                }
                else if((first_side!=second_side) && (first_side!=third_side) && (second_side != third_side))
                {
                    triangle_type = " And the formed Triangle is Scalene";
                }
                else
                {
                    triangle_type = " And the formed Triangle is Isosceles";
                }

                return_string = triangle + triangle_type;
            }
            else
            {
                return_string = "The input sides do not form any Triangle";
            }

            return return_string;
        }
    }
}
