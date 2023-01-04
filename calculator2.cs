using System;\
using System.Linq;\
\
namespace Calculator\
\{\
    class Program\
    \{\
        static void Main(string[] args)\
        \{\
            // create a list of supported operations\
            var operations = new[] \{ "+", "-", "*", "/" \};\
\
            // initialize the result variable\
            double result = 0;\
\
            // run the calculator until the user decides to quit\
            while (true)\
            \{\
                // prompt the user for the first number\
                Console.Write("Enter the first number: ");\
                string input = Console.ReadLine();\
\
                // check if the user has entered "q" to quit the program\
                if (input == "q")\
                \{\
                    break;\
                \}\
\
                // try to convert the user's input to a double\
                double num1;\
                bool success = double.TryParse(input, out num1);\
\
                // if the conversion fails, print an error message and continue to the next iteration\
                if (!success)\
                \{\
                    Console.WriteLine("Error: invalid input. Please enter a valid number or 'q' to quit.");\
                    continue;\
                \}\
\
                // prompt the user for the second number\
                Console.Write("Enter the second number: ");\
                input = Console.ReadLine();\
\
                // check if the user has entered "q" to quit the program\
                if (input == "q")\
                \{\
                    break;\
                \}\
\
                // try to convert the user's input to a double\
                double num2;\
                success = double.TryParse(input, out num2);\
\
                // if the conversion fails, print an error message and continue to the next iteration\
                if (!success)\
                \{\
                    Console.WriteLine("Error: invalid input. Please enter a valid number or 'q' to quit.");\
                    continue;\
                \}\
\
                // prompt the user for the operation to perform\
                Console.Write("Enter the operation (+, -, *, /): ");\
                input = Console.ReadLine();\
\
                // check if the user has entered "q" to quit the program\
                if (input == "q")\
                \{\
                    break;\
                \}\
\
                // check if the user's input is a supported operation\
                if (!operations.Contains(input))\
                \{\
                    Console.WriteLine("Error: invalid operation. Please enter one of the following: +, -, *, /");\
                    continue;\
                \}\
\
                // perform the selected operation on the two numbers\
                if (input == "+")\
                \{\
                    result = num1 + num2;\
                \}\
                else if (input == "-")\
                \{\
                    result = num1 - num2;\
                \}\
                else if (input == "*")\
                \{\
                    result = num1 * num2;\
                \}\
                else if (input == "/")\
                \{\
                    result = num1 / num2;\
                \}\
\
                // print the result\
                Console.WriteLine($"\{num1\} \{input\} \{num2\} = \{result\}");\
            \}\
        \}\
    \}\
\}\
}