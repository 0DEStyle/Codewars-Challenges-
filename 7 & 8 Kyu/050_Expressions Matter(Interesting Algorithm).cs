/*Challenge link:https://www.codewars.com/kata/5ae62fcf252e66d44d00008e/train/csharp
Question:
Task
Given three integers a ,b ,c, return the largest number obtained after inserting the following operators and brackets: +, *, ()
In other words , try every combination of a,b,c with [*+()] , and return the Maximum Obtained (Read the notes for more detail about it)
Example
With the numbers are 1, 2 and 3 , here are some ways of placing signs and brackets:

1 * (2 + 3) = 5
1 * 2 * 3 = 6
1 + 2 * 3 = 7
(1 + 2) * 3 = 9
So the maximum value that you can obtain is 9.

Notes
The numbers are always positive.
The numbers are in the range (1  ≤  a, b, c  ≤  10).
You can use the same operation more than once.
It's not necessary to place all the signs and brackets.
Repetition in numbers may occur .
You cannot swap the operands. For instance, in the given example you cannot get expression (1 + 3) * 2 = 8.
Input >> Output Examples:
expressionsMatter(1,2,3)  ==>  return 9
Explanation:
After placing signs and brackets, the Maximum value obtained from the expression (1+2) * 3 = 9.

expressionsMatter(1,1,1)  ==>  return 3
Explanation:
After placing signs, the Maximum value obtained from the expression is 1 + 1 + 1 = 3.

expressionsMatter(9,1,1)  ==>  return 18
Explanation:
After placing signs and brackets, the Maximum value obtained from the expression is 9 * (1+1) = 18. ___# Task

Given three integers a ,b ,c, return the largest number obtained after inserting the following operators and brackets: +, *, ()
In other words , try every combination of a,b,c with [*+()] , and return the Maximum Obtained
Example
With the numbers are 1, 2 and 3 , here are some ways of placing signs and brackets:

1 * (2 + 3) = 5
1 * 2 * 3 = 6
1 + 2 * 3 = 7
(1 + 2) * 3 = 9
So the maximum value that you can obtain is 9.

Notes
The numbers are always positive.
The numbers are in the range (1  ≤  a, b, c  ≤  10).
You can use the same operation more than once.
It's not necessary to place all the signs and brackets.
Repetition in numbers may occur .
You cannot swap the operands. For instance, in the given example you cannot get expression (1 + 3) * 2 = 8.
Input >> Output Examples:
expressionsMatter(1,2,3)  ==>  return 9
Explanation:
After placing signs and brackets, the Maximum value obtained from the expression (1+2) * 3 = 9.

expressionsMatter(1,1,1)  ==>  return 3

*/

//***************Solution********************
//Check the following expressions, return the max result.
//Then simiplfied into one line by using an Enumerable methods.

using System.Linq;
public class Kata
{
    public static int ExpressionsMatter(int a, int b, int c) =>
      new[] {
          a+b+c,
          a+b*c,
          a*b+c,
          a*b*c,
          (a+b)*c,
          a*(b+c)
        }.Max();
}

//****************Sample Test*****************
namespace Solution
{
    using System;
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class ExpressionsMatter
    {
        [TestCase(6, 2, 1, 2)]
        [TestCase(3, 1, 1, 1)]
        [TestCase(4, 2, 1, 1)]
        [TestCase(9, 1, 2, 3)]
        [TestCase(5, 1, 3, 1)]
        [TestCase(8, 2, 2, 2)]
        public void CheckSmallValues(int expected, params int[] a)
        {
            Assert.That(Kata.ExpressionsMatter(a[0], a[1], a[2]), Is.EqualTo(expected));
        }
        [TestCase(020, 5, 1, 3)]
        [TestCase(105, 3, 5, 7)]
        [TestCase(035, 5, 6, 1)]
        [TestCase(008, 1, 6, 1)]
        [TestCase(014, 2, 6, 1)]
        [TestCase(048, 6, 7, 1)]
        public void CheckIntermediateValues(int expected, params int[] a)
        {
            Assert.That(Kata.ExpressionsMatter(a[0], a[1], a[2]), Is.EqualTo(expected));
        }
        [TestCase(060, 02, 10, 03)]
        [TestCase(027, 01, 08, 03)]
        [TestCase(126, 09, 07, 02)]
        [TestCase(020, 01, 01, 10)]
        [TestCase(018, 09, 01, 01)]
        [TestCase(300, 10, 05, 06)]
        [TestCase(012, 01, 10, 01)]
        public void CheckMixedValues(int expected, params int[] a)
        {
            Assert.That(Kata.ExpressionsMatter(a[0], a[1], a[2]), Is.EqualTo(expected));
        }

        [Test]
        public void RandomTests()
        {
            Random rnd = new Random();
            for (var i = 0; i <= 100; i++)
            {
                var a = rnd.Next(1, 10);
                var b = rnd.Next(1, 10);
                var c = rnd.Next(1, 10);
                var expected = SolutionExpressionsMatter(a, b, c);
                Assert.That(Kata.ExpressionsMatter(a, b, c), Is.EqualTo(expected));
            }
        }
        static int SolutionExpressionsMatter(int a, int b, int c) => new[] { a * (b + c), a * b * c, (a + b) * c, a + b + c, a * b + c, a + b * c }.Max();
    }
}
