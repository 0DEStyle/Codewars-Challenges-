Note: This is a reference document that includes useful snippet of codes that perform small tasks. It is constantly being updated as I learn.

- Data Type - 
Nullable int
int? test = null;

- Print out Array -
Console.WriteLine(String.Join(" ", test).ToArray());

- Get first digit - 
int firstDigit = number.ToString().Substring(0,1)
int firstTwoDigits = number.ToString().Substring(0,2);
int firstDigit = (int)(Value.ToString()[0]) - 48;
int firstDigit = (int)(Value / Math.Pow(10, (int)Math.Floor(Math.Log10(Value))));

- String Manuipulation - 
Remove character from string (seek 048_Remove exclamation marks)
public static string RemoveExclamationMarks(string s) => Regex.Replace(s,@"!", "");
or
public static string RemoveExclamationMarks(string s) => s.Replace("!", "");

Break Camel Case (seek 6 Kyu 018_Break camelCase)
public static string BreakCamelCase(string str) => string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
or using Regex
public static string BreakCamelCase(string str)=> new Regex("([A-Z])").Replace(str, " $0");


- Array -

Declare Array
int[] a = new int[] { 6,6,6,6,1 ,10, 10,10,10,10};
Empty array
string[] a = new string[] { };
or
string[] a = new string[] {0};
Convert an Array to List
a = b.ToList();

Dynamic 2D array (Seek 6 Kyu 019_Logistic Map)
var a = new int[height, width];
Print out 2D array
Console.WriteLine(String.Join(" ", array2D.Cast<int>()));

- List -
Library
using System.Collections.Generic;

Initialize List
List<double> num = new List<double>(new double[10]);
Empty List
List<double> num = new List<double>();
Convert an List to Array
a = b.ToArray();

Nested/2D list (ref https://www.youtube.com/watch?v=6-cuxfD3lvg)
List<List<int>> LogisticMap = new List<List<int>>();
LogisticMap.Add(new List<int> { 1, 2, 3 });
LogisticMap.Add(new List<int> { 4, 5, 6 });

foreach (var list in LogisticMap){
    //print list //Console.WriteLine(String.Join(" ", list));
    foreach (var item in list)
        Console.WriteLine(String.Join(" ", item)); //print items inside list
}



- Ternary Sign -
return n == 0 ? new double[]{0} : res;
or Lambda expressions
=> n == 0 ? new double[]{0} : res;
Declare an Array with Lambda expressions
public static int[] minMax(int[] lst) => new int[] {lst.Min(), lst.Max()};
Declare an Predefined Array with Lambda expressions and select one element
public static string HowMuchILoveYou(int nb_petals)=>  
  new string[] {"I love you", "a little", "a lot", "passionately", "madly", "not at all"}[(nb_petals - 1) % 6];
  
  
- Lambda Expressions - 
Check whether a string is Isograms or not (seek 7 & 8 Kyu > 047_Isograms)
=> str.ToLower().Distinct().Count()==str.Length;

Given an array of integers, find the one that appears an odd number of times. (seek 6 Kyu 013_Find the odd int)
public static int find_it(int[] seq) => seq.First(x => seq.Count(y => y == x) % 2 == 1);

Example of how to set multiple conditions in a Lambda Expression (calculate BMI)
public static string Bmi(double w, double h) => (w = w / h / h) > 30 ? "Obese" : w > 25 ? "Overweight" : w > 18.5 ? "Normal" : "Underweight";

Linq Max (seek 7 & 8 Kyu 050_Expressions Matter)
public static int ExpressionsMatter(int a, int b, int c) => new[] { a+b+c, a+b*c, a*b+c, a*b*c, (a+b)*c, a*(b+c)}.Max();

Replace Repeated Character (seek 6 Kyu 014_Duplicate Encoder)
public static string DuplicateEncode(string word)=> new string(word.ToLower() .Select(x => word.ToLower().Count(y => x == y) == 1 ? '(' : ')').ToArray());

Linq Find stray number (seek 7 & 8 Kyu 051_Find the stray number)
public static int Stray(int[] numbers) => numbers.Aggregate((a, b) => a ^ b);
or
public static int Stray(int[] numbers) => numbers.GroupBy(a => a).Single(b => b.Count() == 1).Key;

For Loop with Linq
Enumerable.Range(start, count)...

If statement with Linq
.Where(x => !someString.Contains("5"))...

- Null - 
Check Null (seek 6 Kyu 016_Simple Encryption)
string.IsNullOrWhiteSpace(text)
string.IsNullOrEmpty(text)
if (string.IsNullOrEmpty(text) || n <= 0) { return text; }
text == null


