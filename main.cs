using System;

class MainClass {
  static bool isPrime(int n){
    if(n <= 1){
      return false;
    }
     
    for(int i = 2; i < n; i++){
      if(n%i ==0){
        return false;
      }
    }
    
    return true;
  }

  public static void Main (string[] args) {
     for(int i = 0; i < 100; i++){
       if(isPrime(i)){
        Console.WriteLine("{0} is prime", i);
      }

     }
     
      
    }
  }
