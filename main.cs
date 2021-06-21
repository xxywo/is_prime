using System;

class MainClass {
  static bool isPrime(int n){

    for(int i = 2; i < n; i++){
      if(i%2 ==0){
        return true;
      }
    }
    return false;
  }

  public static void Main (string[] args) {
     if(isPrime(11)){
       Console.Write("11 is prime");
     }
      
    }
  }
