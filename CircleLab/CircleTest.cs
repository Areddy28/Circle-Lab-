using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CircleLab
{
    public class CircleTest
    {
        //Unit tests for calculate area method
        [Fact]       
        public void AreaTest()
        {
            //Arrange
            Circle c = new Circle(5);

            //Act
            double actual = c.CalculateArea;

            //Assert
            Assert.Equal(78.54, actual);
        }

        [Fact]
        public void AreaTest1()
        {
            //Arrange
            Circle c = new Circle(8);

            //Act
            double actual = c.CalculateArea;

            //Assert
            Assert.Equal(201.06, actual);
        }

        [Fact]
        public void AreaTest2()
        {
            //Arrange
            Circle c = new Circle(10);

            //Act
            double actual = c.CalculateArea;

            //Assert
            Assert.Equal(314.16, actual);
        }

        //Unit tests for calculate circumference method
        [Fact]
        public void CircumferenceTest()
        {
            //Arrange
            Circle c = new Circle(6);

            //Act
            double actual = c.CalculateCircumference;

            //Assert
            Assert.Equal(37.7, actual);
        }

        [Fact]
        public void CircumferenceTest1()
        {
            //Arrange
            Circle c = new Circle(9);

            //Act
            double actual = c.CalculateCircumference;

            //Assert
            Assert.Equal(56.55, actual);
        }

        [Fact]
        public void CircumferenceTest2()
        {
            //Arrange
            Circle c = new Circle(7);

            //Act
            double actual = c.CalculateCircumference;

            //Assert
            Assert.Equal(43.98, actual);
        }
    }
}
