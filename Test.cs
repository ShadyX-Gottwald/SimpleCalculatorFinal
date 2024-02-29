//Testing splitting  input For PostFix Notation    

namespace TestingCalculatorLogic;
using System.Collections.Generic;
using System.Text;
using TestingCalculatorLogic;
using System.Text.RegularExpressions;

public class Input {

    public Stack<double> My_Stack { get; set; } = new ();

    public void Break_Down_Input(string input) {

        var queue = new WorkOutQueue();
        var sign_q = new WorkOutQueue();

        var num_collection = Regex.Matches(input, @"\d{1,3}");
        var sign_collection = Regex.Matches(input, @"[\+\-\*\/]");

        // Get All Numbers
        foreach (Match match in num_collection) {
            queue.Enqueue(match.Value);

        } 

        foreach(var n in num_collection) {  
             Console.WriteLine(n);

        }

        //Get all signs
        foreach (Match match in sign_collection) {
            sign_q.Enqueue(match.Value);

        }



        WorkOut(sign_q, queue);


        //return queue;
    }


    public void WorkOut(WorkOutQueue signs, WorkOutQueue digits)
    {

		Console.WriteLine("Digits Count: " + digits.Count); 

        Console.WriteLine(signs.Join());   
        Console.WriteLine(digits.Join());
        


        while (true) {

            if ( digits.Count == 0) {
                break;
            }

            
            var sign = signs.Dequeue();

            if (sign == "+")
            {
               // var result = int.Parse(one) + int.Parse(two);  
               // My_Stack.Push(result);  

                EvaluateSumParamsADD(sign ,digits);
                //Console.WriteLine(result);

                //My_Stack.Push(result);
            }   
            else if(sign == "-") {     

                EvaluateSumParamsSUBTR(sign ,digits);

            }  

             else if(sign == "*") {     

                EvaluateSumParamsMULTI(sign ,digits);

            }  

             else if(sign == "/") {     

                EvaluateSumParamsDIVI(sign ,digits);

            }


        }

    }  

    public void EvaluateSumParamsADD( string sign ,WorkOutQueue digits ) {  

		 double operand1 = 0;   
           
         double operand2 = 0;   

           if(My_Stack.Count != 0 ) {  
                //Set operand1 number to The Answer in the Stack     
                double popped = My_Stack.Pop();    
                 Console.WriteLine("Peek Value: " + digits.Peek())  ;
                var two = digits.Dequeue() ?? "1.0";
                Console.WriteLine($"Popped value: {popped}");
                 operand1 = popped;      
                 operand2 = double.Parse(two) ;     
                 //Add Numbers and Push to Answer Stack.  

                var answer = operand1 + operand2 ;    
                Console.WriteLine($"{operand1} + {operand2}") ;
                My_Stack.Push(answer);  
                Console.WriteLine("Answer pushed: " +answer);
                
                   
           } 
           else {  
                 //Set operand1 number to The Answer in the Stack   
                 operand1 = double.Parse(digits.Dequeue() ?? "0");     
                 Console.WriteLine("Peek Value2: " + digits.Peek())  ;
                 var two = digits.Dequeue() ;

                 operand2 = double.Parse(two) ;     
                 //Add Numbers and Push to Answer Stack.  

                double answer = operand1 + operand2 ;     
                Console.WriteLine($"{operand1} + {operand2}") ;
                My_Stack.Push(answer);   
                Console.WriteLine("Answer pushed2: " +answer);

           }

    }  

    public void EvaluateSumParamsSUBTR( string sign ,WorkOutQueue digits ) {      

         double operand1 = 0;   
           
         double operand2 = 0;   

           if(My_Stack.Count != 0 ) {  
                //Set operand1 number to The Answer in the Stack     
                double popped = My_Stack.Pop();    
                 Console.WriteLine("Peek Value: " + digits.Peek())  ;
                var two = digits.Dequeue() ?? "1.0";
                Console.WriteLine($"Popped value: {popped}");
                 operand1 = popped;      
                 operand2 = double.Parse(two) ;     
                 //Add Numbers and Push to Answer Stack.  

                var answer = operand1 - operand2 ;    
                Console.WriteLine($"{operand1} - {operand2}") ;
                My_Stack.Push(answer);  
                Console.WriteLine("Answer pushed: " +answer);
                
                   
           } 
           else {  
                 //Set operand1 number to The Answer in the Stack   
                 operand1 = double.Parse(digits.Dequeue() ?? "0");     
                 Console.WriteLine("Peek Value2: " + digits.Peek())  ;
                 var two = digits.Dequeue() ;

                 operand2 = double.Parse(two) ;     
                 //Add Numbers and Push to Answer Stack.  

                double answer = operand1 - operand2 ;     
                Console.WriteLine($"{operand1} - {operand2}") ;
                My_Stack.Push(answer);   
                Console.WriteLine("Answer pushed2: " +answer);

           }





    }  

     public void EvaluateSumParamsMULTI( string sign ,WorkOutQueue digits ) {      

         double operand1 = 0;   
           
         double operand2 = 0;   

           if(My_Stack.Count != 0 ) {  
                //Set operand1 number to The Answer in the Stack     
                double popped = My_Stack.Pop();    
                 Console.WriteLine("Peek Value: " + digits.Peek())  ;
                var two = digits.Dequeue() ?? "1.0";
                Console.WriteLine($"Popped value: {popped}");
                 operand1 = popped;      
                 operand2 = double.Parse(two) ;     
                 //Add Numbers and Push to Answer Stack.  

                var answer = operand1 * operand2 ;    
                Console.WriteLine($"{operand1} * {operand2}") ;
                My_Stack.Push(answer);  
                Console.WriteLine("Answer pushed: " +answer);
                
                   
           } 
           else {  
                 //Set operand1 number to The Answer in the Stack   
                 operand1 = double.Parse(digits.Dequeue() ?? "0");     
                 Console.WriteLine("Peek Value2: " + digits.Peek())  ;
                 var two = digits.Dequeue() ;

                 operand2 = double.Parse(two) ;     
                 //Add Numbers and Push to Answer Stack.  

                double answer = operand1 * operand2 ;     
                Console.WriteLine($"{operand1} * {operand2}") ;
                My_Stack.Push(answer);   
                Console.WriteLine("Answer pushed2: " +answer);

           }    

    }  

     public void EvaluateSumParamsDIVI( string sign ,WorkOutQueue digits ) {      

         double operand1 = 0;   
           
         double operand2 = 0;   

           if(My_Stack.Count != 0 ) {  
                //Set operand1 number to The Answer in the Stack     
                double popped = My_Stack.Pop();    
                 Console.WriteLine("Peek Value: " + digits.Peek())  ;
                var two = digits.Dequeue() ?? "1.0";
                Console.WriteLine($"Popped value: {popped}");
                 operand1 = popped;      
                 operand2 = double.Parse(two) ;     
                 //Add Numbers and Push to Answer Stack.  

                var answer = operand1 / operand2 ;    
                Console.WriteLine($"{operand1} / {operand2}") ;
                My_Stack.Push(answer);  
                Console.WriteLine("Answer pushed: " +answer);
                
                   
           } 
           else {  
                 //Set operand1 number to The Answer in the Stack   
                 operand1 = double.Parse(digits.Dequeue() ?? "0");     
                 Console.WriteLine("Peek Value2: " + digits.Peek())  ;
                 var two = digits.Dequeue() ;

                 operand2 = double.Parse(two) ;     
                 //Add Numbers and Push to Answer Stack.  

                double answer = operand1 / operand2 ;     
                Console.WriteLine($"{operand1} / {operand2}") ;
                My_Stack.Push(answer);   
                Console.WriteLine("Answer pushed2: " +answer);

           }    

    }

}
