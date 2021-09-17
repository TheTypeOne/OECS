using System;

namespace Lesson1
{
    class Program
{
	static string globalVariable = "Global variable";

	static void MethodA()
	{
		if (globalVariable == "")
		{
			string temporalVariable = "Temporal variable";
			Console.WriteLine(temporalVariable);
		}

		string localVariable = "Local variable";
		
		// Так можно — эта переменная используется в той же области, где и объявлена:
		Console.WriteLine(localVariable);
		
		// Так нельзя — temporalVariable определена только внутри блока if:
		// Console.WriteLine(temporalVariable); 
	}

	static void MethodB()
	{
		// Console.WriteLine(localVariable); //Нельзя — переменная определена в другом методе.
		Console.WriteLine(globalVariable); //Можно — это глобальная переменная

	}
}
}
