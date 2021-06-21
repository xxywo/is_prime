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
     for(int i = 0; i < 100; i++){
       if(isPrime(i)){
        Console.WriteLine("{0} is prime", i);
      }

     }
     
      
    }
  }
