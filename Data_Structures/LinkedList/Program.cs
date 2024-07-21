using System;
using System.Collections.Generic;

namespace  LinkedList {

    public class Program {

        public static void Main(string[] args) {
            LinkList list = new LinkList();
            LinkList list2 = new LinkList();
            LinkList list3 = new LinkList();
            int[] Case1={
                  5,
                  20,
                  20,
                  10,
                  5,
                  10
                  };
            int[] Case2={
                1,
                2,
                3,
                2,
                4,
                3
                };
            int[] Case3={
                  7,
                  7,
                  7,
                  7
            };
                foreach (var link in Case1){
                list.Add(link);
            }
              foreach (var link in Case2){
                list2.Add(link);
            }
              foreach (var link in Case3){
                list3.Add(link);
            }
                // AddToList(list,Case1);  
                // list.Remove(10);
                // var results = list.Includes(10);
                // Console.WriteLine(results);
                list.RemoveDuplicate();
                list2.RemoveDuplicate();
                list3.RemoveDuplicate();
                list.Print();
                list2.Print();
                list3.Print();
                      }
        static void AddToList(LinkList list, int[] Output){
            foreach (var link in Output){
                list.Add(link);
            }
        }
    }
}