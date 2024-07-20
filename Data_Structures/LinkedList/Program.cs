using System;
using System.Collections.Generic;

namespace  LinkedList {

    public class Program {

        public static void Main(string[] args) {
            LinkList list = new LinkList();
            int[] Case1={
                  5,
                  10,
                  20,
                  30
            };
                foreach (var link in Case1){
                list.Add(link);
            }
                // AddToList(list,Case1);  
                list.Remove(10);
                var results = list.Includes(10);
                Console.WriteLine(results);
                list.Print();
                      }
        static void AddToList(LinkList list, int[] Output){
            foreach (var link in Output){
                list.Add(link);
            }
        }
    }
}