using System; 

public class PrimeNumbersCSharp{  

    public static void Main(){

    int number,counter;
	
	Console.Write("\n\n");
    Console.Write("Find the Prime numbers within a range of numbers:\n");
    Console.Write("\n\n");  	

    Console.Write("Enter the starting range: ");
    int startingRange = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the ending range: ");
    int endingRange = Convert.ToInt32(Console.ReadLine());

    Console.Write("The prime numbers between {0} and {1} are: \n",startingRange,endingRange);
  
    for(number = startingRange;number<=endingRange;number++){
         counter = 0;

         for(int i=2; i<=number/2; i++){
             if(number%i ==0 ){
                 counter++;
                 break;
             }
        }
        
         if(counter==0 && number!= 0 && number!= 1)
             Console.Write("{0} ",number);
    }
    Console.Write("\n"); 
  } 
}