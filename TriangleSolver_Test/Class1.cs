using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment02;

namespace TriangleSolver_Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Analyze_test_input_side1_10_side2_10_side3_10_returns_Triangle_formed_is_Equilateral_Triangle()
        {

            //Arrange
            int side1 = 10;
            int side2 = 10;
            int side3 = 10;

            string expectedResult = "The input sides do form a Triangle\n And the formed Triangle is Equilateral\n";

            //Act
            string actualResult = TriangleSolver.Analyze(side1,side2,side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_test_input_side1_5_side2_5_side3_8_returns_Triangle_formed_is_Isosceles_Triangle()
        {

            //Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 8;

            string expectedResult = "The input sides do form a Triangle\n And the formed Triangle is Isosceles\n";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_test_input_side1_5_side2_6_side3_7_returns_Triangle_formed_is_Scalene_Triangle()
        {

            //Arrange
            int side1 = 5;
            int side2 = 6;
            int side3 = 7;

            string expectedResult = "The input sides do form a Triangle\n And the formed Triangle is Scalene\n";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [Test]
        public void Analyze_test_input_side1_2_side2_3_side3_7_returns_Input_Sides_Do_not_Form_any_Triangle()
        {
            
            //Arrange
            int side1 = 2;
            int side2 = 3;
            int side3 = 7;

            string expectedResult = "The input sides do not form any Triangle\n";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_test_input_side1_32500_side2_32500_side3_32500_returns_Triangle_formed_is_Equilateral_Triangle()
        {

            //Arrange
            int side1 = 32500;
            int side2 = 32500;
            int side3 = 32500;

            string expectedResult = "The input sides do form a Triangle\n And the formed Triangle is Equilateral\n";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_test_input_side1_32000_side2_32000_side3_30000_returns_Triangle_formed_is_Isosceles_Triangle()
        {

            //Arrange
            int side1 = 32000;
            int side2 = 32000;
            int side3 = 30000;

            string expectedResult = "The input sides do form a Triangle\n And the formed Triangle is Isosceles\n";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_test_input_side1_28000_side2_29000_side3_30000_returns_Triangle_formed_is_Scalene_Triangle()
        {

            //Arrange
            int side1 = 28000;
            int side2 = 29000;
            int side3 = 30000;

            string expectedResult = "The input sides do form a Triangle\n And the formed Triangle is Scalene\n";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [Test]
        public void Analyze_test_input_side1_30000_side2_31000_side3_500_returns_Input_Sides_Do_not_Form_any_Triangle()
        {

            //Arrange
            int side1 = 30000;
            int side2 = 31000;
            int side3 = 500;

            string expectedResult = "The input sides do not form any Triangle\n";

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
