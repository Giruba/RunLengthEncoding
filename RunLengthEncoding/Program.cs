using System;

namespace RunLengthEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Run Length Encoding!");
            Console.WriteLine("--------------------");

            Console.WriteLine("Enter the string for run length encoding");
            String stringInput = Console.ReadLine();
            String stringOutput = GetRunLengthEncodedString(stringInput);
            if (!string.IsNullOrEmpty(stringOutput)){
                Console.WriteLine("Output --- Run Length Encoded string is " + stringOutput);
            }

            Console.ReadLine();
        }

        private static string GetRunLengthEncodedString(string stringInput) {
            String output = null;

            try
            {
                if (string.IsNullOrEmpty(stringInput))
                {
                    Console.WriteLine("The entered string is null");
                    return output;
                }
                else {
                    int length = (2 * stringInput.Length) + 1;
                    int outputStringIndex = 0;
                    char[] inputCharArray = new char[length];
                    for (int i = 0; i < stringInput.Length; i++) {
                        int count = 0;
                        while (i + 1 < stringInput.Length &&
                                stringInput[i] == stringInput[i + 1]) {
                            count++;
                            i++;
                        }
                        count = count + 1;
                        inputCharArray[outputStringIndex++] = stringInput[i];
                        char[] numArray = count.ToString().ToCharArray();
                        for (int j = 0; j < numArray.Length; j++){
                            inputCharArray[outputStringIndex++] = numArray[j];
                        }
                    }
                    return new string(inputCharArray);
                }
            }catch(Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return output;
        }
    }
}
