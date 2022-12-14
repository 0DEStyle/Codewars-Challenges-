/*Challenge link:https://www.codewars.com/kata/57f609022f4d534f05000024/train/csharp
Question:
You are given an odd-length array of integers, in which all of them are the same, except for one single number.

Complete the method which accepts such an array, and returns that single different number.

The input array will always be valid! (odd-length >= 3)

Examples
[1, 1, 2] ==> 2
[17, 17, 3, 17, 17, 17, 17] ==> 3

*/

//***************Solution********************
//Solution 1
//Group elements by number
//get the single element where the number of element is 1
//return the key element as result.
//Then simiplfied into one line by using an Lambda expression with Enumerable methods.

using System.Linq;
class Solution 
{
  public static int Stray(int[] numbers) => 
    numbers.GroupBy(a => a).Single(b => b.Count() == 1).Key;
}

//Solution 2
//xor current element with next element, and aggregate the result
//a a 0
//a b 1
//b a 1
//b b 0
//if the numbers are the same, it will turn into 0
//so only the stray number is left as a result.

using System.Linq;
class Solution 
{
  public static int Stray(int[] numbers) => 
    numbers.Aggregate((a, b) => a ^ b);
}



//****************Sample Test*****************
using NUnit.Framework;
using System;

[TestFixture]
public class SolutionTest
{
  [Test]
  public void SimpleArray1()
  {
    Assert.AreEqual(2, Solution.Stray(new int[] {1, 1, 2}));
  }
  
  [Test]
  public void SimpleArray2()
  {
    Assert.AreEqual(3, Solution.Stray(new int[] {17, 17, 3, 17, 17, 17, 17}));
  }
  
  [Test]
  public void FirstItem()
  {
    Assert.AreEqual(8, Solution.Stray(new int[] {8, 1, 1, 1, 1, 1, 1}));
  }
  
  [Test]
  public void LastItem()
  {
    Assert.AreEqual(0, Solution.Stray(new int[] {1, 1, 1, 1, 1, 1, 0}));
  }
  
  [Test]
  public void MiddleItem()
  {
    Assert.AreEqual(7, Solution.Stray(new int[] {0, 0, 0, 7, 0, 0, 0}));
  }
  
  [Test]
  public void SimpleArray3()
  {
    Assert.AreEqual(-6, Solution.Stray(new int[] {-21, -21, -21, -21, -6, -21, -21}));
  }
  
  [Test]
  public void RandomSmallArray()
  {
    int strayNumber = SolutionHelper.RandomInt(-10000, 10000);
    int[] array = SolutionHelper.ValidRandomArray(101, strayNumber);
    Assert.AreEqual(strayNumber, Solution.Stray(array));
  }
  
  [Test]
  public void RandomBigArray()
  {
    int strayNumber = SolutionHelper.RandomInt(-10000, 10000);
    int[] array = SolutionHelper.ValidRandomArray(15273, strayNumber);
    Assert.AreEqual(strayNumber, Solution.Stray(array));
  }
}
