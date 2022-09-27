using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void GetSquaresTest1()
        {
            var a = 100; var b = 30;

            List<Square> squares = new List<Square>();
            Square square;

            square.side = 30; square.amount = 3;
            squares.Add(square);
            square.side = 10; square.amount = 3;
            squares.Add(square);

            List<Square> message = Logic.GetSquares(a, b);

            String message1 = "";
            String message2 = "";

            foreach (var item in squares)
            {
                message1 = message1 + item.side.ToString() + " ";
                message1 = message1 + item.amount.ToString() + " ";
            }

            foreach (var item in message)
            {
                message2 = message2 + item.side.ToString() + " ";
                message2 = message2 + item.amount.ToString() + " ";
            }

            Assert.AreEqual(message1, message2);
        }

        [TestMethod()]
        public void GetSquaresTest2()
        {
            var a = 100; var b = 100;

            List<Square> squares = new List<Square>();
            Square square;

            square.side = 100; square.amount = 1;
            squares.Add(square);

            List<Square> message = Logic.GetSquares(a, b);

            String message1 = "";
            String message2 = "";

            foreach (var item in squares)
            {
                message1 = message1 + item.side.ToString() + " ";
                message1 = message1 + item.amount.ToString() + " ";
            }

            foreach (var item in message)
            {
                message2 = message2 + item.side.ToString() + " ";
                message2 = message2 + item.amount.ToString() + " ";
            }

            Assert.AreEqual(message1, message2);
        }

        [TestMethod()]
        public void GetSquaresTest3()
        {
            var a = 25; var b = 132;

            List<Square> squares = new List<Square>();
            Square square;

            square.side = 25; square.amount = 5;
            squares.Add(square);
            square.side = 7; square.amount = 3;
            squares.Add(square);
            square.side = 4; square.amount = 1;
            squares.Add(square);
            square.side = 3; square.amount = 1;
            squares.Add(square);
            square.side = 1; square.amount = 3;
            squares.Add(square);

            List<Square> message = Logic.GetSquares(a, b);

            String message1 = "";
            String message2 = "";

            foreach (var item in squares)
            {
                message1 = message1 + item.side.ToString() + " ";
                message1 = message1 + item.amount.ToString() + " ";
            }

            foreach (var item in message)
            {
                message2 = message2 + item.side.ToString() + " ";
                message2 = message2 + item.amount.ToString() + " ";
            }

            Assert.AreEqual(message1, message2);
        }
    }
}