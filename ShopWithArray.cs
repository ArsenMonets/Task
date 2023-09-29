 using System;

 public class Shop {
    public static void Main(string[] args) {
     string[] productName = {"Milk", "Bread", "Yogurt"};
     int[] price = {2, 1, 3};
     for (int i = 0; i<3; i++) {
     Console.WriteLine (productName[i] + ": " + price[i] + "$");
     }
     
   }
 }