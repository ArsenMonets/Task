#include <iostream> 
#include <string> 
using namespace std; 

int main() {
  string productName[3] = {"Milk", "Bread", "Yogurt"};
  int price[3] = {2, 1, 3};
  for (int i=0; i<3; i++) {
    cout << productName[i] << ": " << price[i] << "$\n";
  }
return 0;
}