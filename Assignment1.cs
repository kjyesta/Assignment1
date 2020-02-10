using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1
{
    
        class Program
        {
            static void Main(string[] args)
            {
                int n = 5;
                PrintPattern(n);

                int n2 = 6;
                PrintSeries(n2);

                string s = "09:15:35PM";
                string t = UsfTime(s);
                Console.WriteLine(t);

                int n3 = 110;
                int k = 11;
                UsfNumbers(n3, k);

                string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
                PalindromePairs(words);


                int n4 = 7;
                Stones(n4);


            }

        /* Description : The below program is for printing the pattern as per given integer using recursion method.*/
            private static void PrintPattern(int n)
            {
                try
                {

                    {
                        //Intialising the variable 
                        int j;

                        // Output the lines
                        Console.Write("\nThe First Program Solution:\n"); 

                        // for loop executes from n=5 to n< 1 and terminates when n value is less than 1
                        for (n = 5; n >= 1; n--)
                        {
                            // for loop executes from j=n to j< 1 and terminates when j value is less than 1
                            for (j = n; j >= 1; j--)
                            {
                                // Printing the j value 
                                Console.Write(j);
                            }

                            // Output the lines using the new newline sequence.
                            Console.WriteLine();
                        }
                    }
                }

                // Exception will be handled by Catch block of Statements
                catch
                {
                    Console.WriteLine("Exception Occured while computing printPattern");
                }
            }

        //** Description : The below program is for printing series of the integers till n value of integer. **
        private static void PrintSeries(int n2)
            {
                try
                {

                    {
                       // Output the lines.
                        Console.Write("\nThe second Program Solution:\n");

                       // Intialising sum as zero value
                       int sum = 0; 

                        // Iteration from i=1 to i is less than the n2
                        for (int i = 1; i <= n2; i++)
                        {
                            // Adding i value to sum in evry iteration
                            sum += i;

                            // Printing Sum value with commma
                            Console.Write(sum + ",");

                        }

                        // Output the lines using the new newline sequence.
                        Console.WriteLine();

                    }

                }

                // Exception will be handled by Catch block of Statements
                catch
                {
                    Console.WriteLine("Exception Occured while computing printSeries");
                }
        }

        /* Description : The below program takes 12HR  format and returns string representing input time in USF time format.*/

        public static string UsfTime(string s)
            {
                try
                {
                    Console.Write("\nThe Third Program Solution:\n"); // Output the lines

                    // Connverting the string of a time interval to its TimeSpan equivalent.
                    TimeSpan ts = DateTime.Parse(s).TimeOfDay;


                    // Calculating the total seconds
                    double seconds = ts.TotalSeconds;

                    double usfhrs, usfmins, usfsecs;

                    //Calculating usf hours from total seconds
                    usfhrs = seconds / (60 * 45);

                    // Converting to integer
                    int usfhr = (int)usfhrs;

                    //Calculating usf mins from total seconds
                    usfmins = ((seconds) % (60 * 45)) / 45;

                    // Converting to integer
                    int usfmin = (int)usfmins;

                    //Calculating usf seconds from total seconds
                    usfsecs = seconds % 45;

                    // Converting to integer
                    int usfsec = (int)usfsecs;

                    // Concatenating hrs,mins and secs and storing in String 
                    string x = ("Output Time: " + usfhr + ":" + usfmin + ":" + usfsec);

                    // Returning the value
                    return x;

                }

                // Exception will be handled by Catch block of Statements
                catch
                {
                    Console.Write("Exception Occured while computing UsfTime");
                }
                return null;
            }

        /* Description : The below program is for printing the pattern of numbers starting
         * from 1 to 110 with 11 numbers per line with checking divisibility as given.*/

        public static void UsfNumbers(int n3, int k)
            {
                try
                {

                    Console.Write("\nThe Fourth Program Solution:\n"); // Output the lines


                    // Iterating from y being 1 to n3 value with y incrementing by 1 on each iteration.
                    for (int y = 1; y <= n3; y++)
                    {

                        // check if y is divisible by 3 and 5 
                        // if:   Outputs 'US' in place of numbers which are multiple of 3 and 5

                        if (y % 3 == 0 && y % 5 == 0)
                        {

                            // check if y is divisible by 11 
                            // if:   Output the lines using the new newline sequence.
                            // else: Output the lines without newline sequence.
                            if (y % k == 0)
                            {
                                Console.WriteLine("US");
                            }
                            else
                            {
                                Console.Write("US ");
                            }
                        }


                        // else if : Outputs 'SF' in place of numbers which are multiple of 5 and 7 
                        else if (y % 5 == 0 && y % 7 == 0)

                        {
                            // check if y is divisible by 11 
                            // if:   Output the lines using the new newline sequence.
                            // else: Output the lines without newline sequence.
                            if (y % k == 0)
                            {
                                Console.WriteLine("SF");
                            }
                            else
                            {
                                Console.Write("SF ");
                            }
                        }

                        // else if : Outputs 'FU' in place of numbers which are multiple of 7 and 3
                        else if (y % 7 == 0 && y % 3 == 0)
                        {
                            // check if y is divisible by 11 
                            // if:   Output the lines using the new newline sequence.
                            // else: Output the lines without newline sequence.
                            if (y % k == 0)
                            {
                                Console.WriteLine("FU");
                            }
                            else
                            {
                                Console.Write("FU ");
                            }
                        }

                        // else if : Outputs 'U' in place of numbers which are multiple of 3
                        else if (y % 3 == 0)
                        {
                            // check if y is divisible by 11 
                            // if:   Output the lines using the new newline sequence.
                            // else: Output the lines without newline sequence.

                            if (y % k == 0)
                            {
                                Console.WriteLine("U");
                            }
                            else
                            {
                                Console.Write("U ");
                            }
                        }

                        // else if : Outputs 'S' in place of numbers which are multiple of 5
                        else if (y % 5 == 0)
                        {
                            // check if y is divisible by 11 
                            // if:   Output the lines using the new newline sequence.
                            // else: Output the lines without newline sequence.
                            if (y % k == 0)
                            {
                                Console.WriteLine("S");
                            }
                            else
                            {
                                Console.Write("S ");
                            }
                        }

                        // else if : Outputs 'F' in place of numbers which are multiple of 7
                        else if (y % 7 == 0)
                        {
                            // check if y is divisible by 11 
                            // if:   Output the lines using the new newline sequence.
                            // else: Output the lines without newline sequence.
                            if (y % k == 0)
                            {
                                Console.WriteLine("F");
                            }
                            else
                            {
                                Console.Write("F ");
                            }
                        }

                        // else: Outputs numbers as it is
                        else
                        {
                            // check if y is divisible by 11 
                            // if:   Output the lines using the new newline sequence.
                            // else: Output the lines without newline sequence.
                            if (y % k == 0)
                            {
                                Console.WriteLine(y);
                            }
                            else
                            {
                                Console.Write(y + " ");
                            }
                        }

                    }

                }

                // Exception will be handled by Catch block of Statements
                catch
                {
                    Console.WriteLine("Exception occured while computing UsfNumbers()");
                }
            }

        /* Description : The below program is to print the pairs of indices of an array of words such that the
        concatenation of those two words is a palindrome  */

        public static void PalindromePairs(string[] words)
            {

                try
                {
                    Console.Write("\nThe fifth Program Solution:\n"); // Output the lines


                    Console.Write("The palindromes are : "); // Output the lines.


                    // Iterating to get all elements of the array string
                    for (int p = 0; p < words.Length; p++)

                    {

                        for (int l = 0; l < words.Length; l++)

                        {
                            // Intialising string to store the concatenated word
                            String Check_Palindrome = "";

                            // Checking if the words are distinct
                            if (p != l)
                            {

                                // Concatenating two words for Palindrome Check
                                Check_Palindrome = words[p] + words[l];

                                // Calculating the length of the word
                                int word_len = Check_Palindrome.Length;
                                string reverse = "";


                                // iterate through each and every character of the string from reverse direction
                                for (int r = word_len - 1; r >= 0; r--)
                                {
                                    //  Adding each character of the string in reverse direction
                                    reverse += Check_Palindrome[r];
                                }

                                // Checking if string is Palindrome or not by comparing reverse string with the intial string
                                if (reverse == Check_Palindrome)
                                {
                                    // Output the pair of distinct indices 
                                    Console.Write("[" + p + "," + l + "]");

                                }

                                else
                                {

                                }
                            }

                        }

                    }
                }

                // Exception will be handled by Catch block of Statements
                catch
                {

                    Console.WriteLine("Exception occured while computing PalindromePairs()");
                }
            }


        /* Description : The below program is to determine which player can win the game given the number of stones in the bag.
         Printing false if Player1 cannot win the game otherwise printing set of moves using array */

        public static void Stones(int n4)
            {
                try
                {

                    Console.Write("\n\nThe Sixth Program Solution:\n");

                    Console.WriteLine("Number Of Stones:" + n4);

                    //Intialising an empty list
                    List<int> array = new List<int>();

                    //Intialising an integer variable named player
                    int Player = 2;

                    //Checks if the value n4 is less than 4
                    if (n4 < 4)
                    {
                        //Outputs the line
                        Console.WriteLine("Winner: Player 1");
                    }

                    //Checks if the value n4 is divisible by 4
                    else if (n4 % 4 == 0)
                    {
                        //Outputs the line
                        Console.WriteLine("False");
                    }

                    else
                    {
                        //Adds the remainder as the first input to the array.
                        array.Add(n4 % 4);
                        Console.WriteLine("Player 1 - " + (n4 % 4));


                        //Checks if the sum of array is not equal to n4
                        while (array.Sum() != n4)
                        {
                            Console.WriteLine("Player " + Player + " - ");

                            //Converts the value to integer
                            int player_input = Convert.ToInt32(Console.ReadLine());


                            //Checks if the user input is not in between 0 to 3, or sum of the array is not greater than n4
                            if (player_input < 0 || player_input > 3 || (array.Sum() + player_input > n4))
                            {

                                Console.WriteLine("You have entered a wrong option!!");

                            }


                            else
                            {
                                //Adds the user input to list array
                                array.Add(player_input);

                                //Changes the value of player from 1 to 2 alternatively
                                Player = (Player == 1 ? 2 : 1);
                            }
                        }
                    }

                    //Outputs all the values in list array
                    Console.WriteLine("[" + String.Join(", ", array) + "]");


                }

                // Exception will be handled by Catch block of Statements
                catch
                {
                    Console.WriteLine("Exception occured while computing Stones()");
                }
            }


        }

    }



