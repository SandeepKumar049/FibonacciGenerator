using System;  
  public class FibonacciGenerator  
   {  
     public static void Main(string[] args)  
      {  
         int n1=0,n2=1,n3=1,number;    
         Console.Write("Enter the number of elements: ");    
         number = int.Parse(Console.ReadLine());  
         Console.Write(n1+" "+n2+" "); 
         n3=fibonacciCalculator( n1,n2,n3,number);
      }
      public static int fibonacciCalculator(int n1, int n2, int n3,int number)
      {
         for(int i=2;i<number;++i)   
         {    
          n3=n1+n2;    
          Console.Write(n3+" ");   
          n1=n2;    
          n2=n3;    
         } 
         return n3;
      }  
   }  
