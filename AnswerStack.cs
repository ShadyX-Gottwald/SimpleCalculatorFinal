namespace TestingCalculatorLogic; 

interface IStack {   

    bool IsEmpty();  

    double Push(double answer);  

    double Pop();   

    double Peek();

}

public class AnswerStack : IStack {  

    public List<double> List_Stack {get; set;} = new(); 

    public bool IsEmpty() { 
        if(List_Stack.Count == 0) return true;  
        else return false;
    }

    public double Pop() {
       var last = List_Stack.Last();    

       if(List_Stack.Count ==0) return 0;
       else List_Stack.RemoveAt(List_Stack.Count -1);
      
       return last;
    }

    public double Push(double answer) {List_Stack.Add(answer); return List_Stack.Last(); }


   public  double Peek() =>  List_Stack.LastOrDefault(0);
}