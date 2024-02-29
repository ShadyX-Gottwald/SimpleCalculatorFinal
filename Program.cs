
using System;
using System.Collections.Generic;
using TestingCalculatorLogic;

class Program
{
	// Function to evaluate a postfix expression with numbers
	static double EvaluatePostfix(string postfix)
	{
		Stack<double> stack = new Stack<double>();

		foreach (char c in postfix)
		{
			if (char.IsDigit(c))
			{
				stack.Push(double.Parse(c.ToString())); // Operand, push onto stack
			}
			else if (IsOperator(c))
			{
				double operand2 = stack.Pop();
				double operand1 = stack.Pop();
				double result = ApplyOperator(operand1, operand2, c);
				stack.Push(result); // Push result back onto stack
			}
		}

		return stack.Pop(); // Final result
	}

	// Function to check if a character is an operator
	static bool IsOperator(char c)
	{
		return c == '+' || c == '-' || c == '*' || c == '/';
	}

	// Function to apply an operator to two operands
	static double ApplyOperator(double operand1, double operand2, char op)
	{
		switch (op)
		{
			case '+':
				return operand1 + operand2;
			case '-':
				return operand1 - operand2;
			case '*':
				return operand1 * operand2;
			case '/':
				return operand1 / operand2;
			default:
				throw new ArgumentException("Invalid operator");
		}
	}

	static void Main() {


		var t = new Input();

        t.Break_Down_Input("8/2/4+7*2-4-2"); 
        
        Console.WriteLine(t.My_Stack.Peek());

		//Test();

	}

	private static void Test() {

		var q = new WorkOutQueue();

		q.Enqueue("6");
		q.Enqueue("5");
		q.Enqueue("4");

		Console.WriteLine(q.Dequeue());
		Console.WriteLine(q.Dequeue());

		Console.WriteLine(q.Peek());   
		Console.WriteLine(q.Count);

	}
}
