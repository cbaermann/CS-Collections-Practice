using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            string [] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            string [] boolArr = new string[10];
            string True = "True";
            string False = "False";
            for (int i = 0; i < boolArr.Length; i++){
                if(i%2==0){
                    boolArr[i]=True;
                }
                else{
                    boolArr[i]=False;
                }

            }
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Chunky Monkey");
            flavors.Add("Cookie Dough");

            flavors.Remove("Strawberry");

            Dictionary<string,string> nameKeys = new Dictionary<string,string>();
            foreach( var name in names){
                nameKeys.Add(name, null);
            }
            Random rand = new Random();
            foreach( var name in names){
                int randInx = rand.Next(flavors.Count-1);
                nameKeys[name] = flavors[randInx];
                flavors.RemoveAt(randInx);
            }

            foreach(var entry in nameKeys){
                Console.WriteLine("{0}'s favorite flavor is {1}", entry.Key, entry.Value);
            }

        }
    }
}
