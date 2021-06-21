using System;
//version 1, might need to optimize
//set timer to see the performancn
//using recusive to implement isPrime, timer indicated that the Execution time did not get shorter
  


class MainClass {
  
  //original function had a Execution time of 80ms
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
  //optimized function had a Execution time of 69ms
  static bool is_Prime(int num){
    bool isp = true;
    if(num <=1){
      return false;
    }
    for(int i=2; i<= Math.Sqrt(num) ; i++)
        {
            if(num%i == 0)
            {
                isp=false;
                break;
            }
        }
        if(isp)
        {
            return true;
        }
        else{
          return false;
        }
      
      
  }
  //main funtion 
  public static void Main (string[] args) {
    //test case
    var watch = new System.Diagnostics.Stopwatch();
    watch.Start();
     for(int i = 0; i < 10; i++){
       if(isPrime(i)){
        Console.WriteLine("{0} is prime", i);
      }

     }
     watch.Stop();
     Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");


     
      
    }
  }
//reference
//optimize code
//https://stackoverflow.com/questions/15743192/check-if-number-is-prime-number
//using git
//https://www.youtube.com/watch?v=SWYqp7iY_Tc
//c##
//https://www.youtube.com/watch?v=GhQdlIFylQ8