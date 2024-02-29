using System.Text;

namespace TestingCalculatorLogic;

interface IQueue {

      int Count { get;  }

      string? Dequeue();

      string Enqueue(string number);   

      string? Peek();   

      string Join();


}

public class WorkOutQueue : IQueue {  

      public List<string> Queue = new();
      public int Count { get => Queue.Count; }

      public string? Dequeue() {  

           if(Queue.Count == 0) return null;
           
           else {   

                var previousFirst = Queue.Last();  
                 Queue.RemoveAt(Queue.Count -1); 

                return previousFirst;
           }
            
      }

      public string Enqueue(string number) {  

            Queue.Insert(0, number) ; 
            return number;

      } 

      public string? Peek() =>  Queue.FirstOrDefault("0");  

      public string Join() {  
            var sb = new StringBuilder();   

            foreach(var str in Queue) sb.Append(str);

            return sb.ToString();
      }

      
}
