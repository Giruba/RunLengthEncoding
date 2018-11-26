Author: Giruba Beulah SE

# RunLengthEncoding
C# program to print the run length encoding of a string

Run Length Encoding of a string is the combination of the character and the number of times the character appears
in the string consecutively.

For Example: Given a string WELCOME, the run length encoding will be W1E1L1C1O1M1E1
Note: The run length encoding of this string is double the size of the input string, as there are no repetitive characters.

Another Example: PIINESSS
Run Length encoding of this string is P1I2N1E1S3

Algorithm/Logic
---------------
1. Create a charArray of length 2*InpuStringLength+1
2. Iterate over input string with indices for input string, output char array and initialize count = 0
  2.a While a character is equal to the next character, increment input string index and count
      2.a.1 Put the character in the output char array
      2.a.2 Convert the number to chars and place them in the output char array
3. Convert the char array to a string to be printed as the output

