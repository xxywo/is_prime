using System;
//version 1, might need to optimize
//set timer to see the performancn



class MainClass {
  static bool isPrime(int n){
    if(n <= 1){//when n is negative or 1
      return false;
    }
     
    for(int i = 2; i < n; i++){
      //a prime number only divisible by 1 and itself
      //if n is divisible to any number other than 1 and itself, it's not a prime number
      if(n%i ==0){
        return false;
      }
    }
    
    return true;
  }
  //main funtion 
  public static void Main (string[] args) {
    //test case
    var watch = new System.Diagnostics.Stopwatch();
    watch.Start();
     for(int i = 0; i < 100; i++){
       if(isPrime(i)){
        Console.WriteLine("{0} is prime", i);
      }

     }
     watch.Stop();
     Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

     
      
    }
  }
