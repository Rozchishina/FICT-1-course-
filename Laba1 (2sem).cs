using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;

//task1
int sumOfNegativeNum = 0;
int nunberOfNegativeNum = 0;
List <int> numbers = new List<int>() { 2, 4,-5,-13,-9,6,20,-3,15,-17,8,3 };
int minNum = numbers[0];
foreach (int num in numbers)
{
    
    if (num < 0 && num<minNum)
    {
        sumOfNegativeNum += num;
        nunberOfNegativeNum++;
        minNum = num;
    }
}
int avarege =sumOfNegativeNum/ nunberOfNegativeNum;
Console.WriteLine("Найменше число у лісті: " + minNum);
Console.WriteLine("Середнє арифметичне від'ємних чисел у лісті: " + avarege);
int index = numbers.IndexOf(minNum);
if (index > -1)
{
    numbers[index] = avarege;
}
Console.WriteLine("Змінений ліст: ");
foreach (int num in numbers)
{
   Console.WriteLine(num);
}
//task2
Dictionary<string, int> capitals = new Dictionary<string, int>();
capitals.Add("K y i v", 1);
capitals.Add("P a r i s", 2);
capitals.Add("B a r c e l o n a", 3);
capitals.Add("W a r s a w", 4);
Dictionary<string, int> newDictionary = new Dictionary<string, int>();
foreach (KeyValuePair<string, int> item in capitals)
{
    string newKey = item.Key.Replace(" ", "");
    newDictionary.Add(newKey, item.Value);
}
foreach (string key in newDictionary.Keys)
{
    Console.WriteLine(key);
}
using (FileStream fs = new FileStream("D:\\laba1.json", FileMode.OpenOrCreate))
{
    JsonSerializer.SerializeAsync<object>(fs, newDictionary);
}
//task3
var months = new List<string>()
{
    "January 31",
    "February 28",
    "March 31",
    "April 30",
    "May 31",
    "June 30",
    "July 31",
    "August 31",
    "September 30",
    "October 31",
    "November 30",
    "December 31"
};
var newlist = months.Where(month => month.Contains("30")).ToList();
foreach (var year in newlist)
{
    Console.WriteLine(year);
}
