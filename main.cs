using System;
//coding assessment for CASA
//finished isPrime, need to optimize
//set timer to see the performancn
//using recusive to implement isPrime, timer indicated that the Execution time did not get shorter (delete it )
//consider that using sqrt(n) work just same as n, implemented is_Prime
//and is_Prime have a better performancn in term of time 


class MainClass {
  
  //original function had a Execution time of 80ms
  //in theory, this function have time complexity  of O(n)
  // and space complexity of O(1)
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
  //reduce the time complexity to O(sqrt(n))
  //and space complexity O(1)
  static bool is_Prime(int num){
    bool isp = true;
    if(num <=1){//corner case
      return false;
    }
    for(int i=2; i<= Math.Sqrt(num) ; i++)//using sqrt(n) instead of n
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