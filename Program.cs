using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /* -----------------  Pattern 1.2  -----------------
             
            1
            2 2
            3 3 3
            4 4 4 4
            5 5 5 5 5
            

            for (int row = 1; row <= 5; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
           
            */


            /* -----------------  Pattern 1.7  -----------------
            
            5
            5 4
            5 4 3
            5 4 3 2 
            5 4 3 2 1
            

            int num = 6;

            for(int row = 1; row <= 5; row++)
            {
                for(int column = 1; column <= row; column++)
                {
                    Console.Write((num - column)  + " ");   // string concatenation
                }
                Console.WriteLine();
            }
            Console.Read();
            
            */


            /* -----------------  Pattern 1.9  -----------------
            
            1
            2 3
            4 5 6
            7 8 9 10


            int k = 1;

            for(int row = 1; row <= 5; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    // Console.Write(k++ + " ");
                    Console.Write("{0,2} ", k++);  // parametric formate.  0 means parameter 1, and 2 means parameter 1 will take 2 digits
                }
                Console.WriteLine();
            }
            Console.Read();
            
            */


            /* -----------------  Pattern 1.5  -----------------            
            1
            0 1
            1 0 1
            0 1 0 1
            1 0 1 0 1

            1
            2 1 
            3 2 1
            4 3 2 1
            5 4 3 2 1
            

            for(int row = 1; row <= 5; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write( (row - column + 1) % 2 + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
            
            */


            /* -----------------  Pattern 1.6  -----------------
             
                    1 
                  1   2 
                1   2   3
              1   2   3   4
            1   2   3   4   5  

            1
            1 2
            1 2 3
            1 2 3 4
            1 2 3 4 5
            

            for(int row = 1; row <= 5; row++)
            {
                for(int space = 1; space <= 5-row; space++)
                {
                    Console.Write(" ");
                }
                for(int column = 1; column <= row; column++)
                {
                    Console.Write((column) + " ");
                }
                Console.WriteLine();
            }
            Console.Read();

            */


            /* -----------------  Pattern 1.1  -----------------
             
                    1 
                  1 2 1
                1 2 3 2 1 
              1 2 3 4 3 2 1
            1 2 3 4 5 4 3 2 1  


            for(int row = 1; row <= 5; row++)
            {
                for(int space = 1; space <= 5-row; space++)
                {
                    Console.Write("  ");
                }
                for(int column = 1; column <= row; column++)       // left 
                {
                    Console.Write((column) + " ");
                }
                for(int column = 1; column <= row-1; column++)
                {
                    Console.Write( row-column + " ");
                }
                Console.WriteLine();
            }
            Console.Read();

            */


            /* -----------------  Pattern 1.8  -----------------
             
            1 * * * *
            1 2 * * *
            1 2 3 * *
            1 2 3 4 *
            1 2 3 4 5


            for(int row = 1; row <= 5; row++)
            {
                for(int column = 1; column <= row; column++)
                {
                    Console.Write((column) + " ");
                }
                for(int star = 1; star <= 5-row; star++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            Console.Read();

            */


            /* -----------------  Pattern 1.3  -----------------
             
            1 
            1 2 
            1 2 3
            1 2 3 4 
            1 2 3 4 5
            1 2 3 4
            1 2 3
            1 2
            1
            

            for(int row = 1; row <= 5; row++)
            {
                for(int column = 1; column <= row; column++)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine();
            }
            
            for(int row = 1; row <= 4; row++)
            {
                for(int column = 1; column <= 5-row; column++)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
            
            */


            /* -----------------  Pattern 1.4  -----------------
            
            1 2 3 4 5
            1 2 3 4 
            1 2 3 
            1 2
            1

            1 
            1 2 
            1 2 3
            1 2 3 4 
            1 2 3 4 5 
            

            for(int row = 1; row <= 5; row++)
            {
                for(int column = 1; column <= 6-row; column++)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine();
            }
        
            Console.WriteLine();

            for(int row = 1; row <= 5; row++)
            {
                for(int column = 1; column <= row; column++)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine();
            }
            Console.Read();            
            
            */
            

            /* -----------------  Pattern 1.10  ----------------
             
                    1 
                  1   2 
                1   2   3
              1   2   3   4
            1   2   3   4   5
              1   2   3   4
                1   2   3
                  1   2
                    1
            

            for(int row = 1; row <= 5; row++)
            {
                for(int space = 1; space <= 5-row; space++)
                {
                    Console.Write("  ");
                }
                for(int column = 1; column <= row; column++)
                {
                    Console.Write(column + "   ");
                }
                Console.WriteLine();
            }
            
            for(int row = 1; row <= 4; row++)
            {
                for(int space = 1; space <= row; space++)
                {
                    Console.Write("  ");
                }
                for(int column = 1; column <= 5-row; column++)
                {
                    Console.Write(column + "   ");
                }
                Console.WriteLine();
            }
            Console.Read();

            */
            

            /* -----------------  Pattern 2.1  -----------------
             
            ********
            ******* 
            ******  
            *****  
            **** 
            ***
            **
            *


            for(int row = 1; row <= 8; row++)
            {
                for(int column = 1; column <= 9-row; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
            
            */


            /* -----------------  Pattern 2.2  -----------------

            *
            **
            ***
            ****
            *****
            ******
            *******
            ********
            

            for(int row = 1; row <= 8; row++)
            {
                for(int column = 1; column <= row; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();

            */


            /* -----------------  Pattern 2.3  -----------------   
             
                  *
                 ***
                *****
               *******
              *********
             ***********
            *************
             ***********
              *********
               *******
                *****
                 ***
                  *               
            

            for(int row = 1; row <= 7; row++)
            {
                for(int space = 1; space <= 7-row; space++)
                {
                    Console.Write(" ");
                }
                for(int column = 1; column <= row; column++)
                {
                    Console.Write("*");
                }
                for(int column = 1; column <= row-1; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int row = 1; row <= 6; row++)
            {
                for(int space = 1; space <= row; space++)
                {
                    Console.Write(" ");
                }
                for(int column = 1; column <= 7-row; column++)
                {
                    Console.Write("*");
                }
                for(int column = 1; column <= 6-row; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();

            */


            /* -----------------  Pattern 2.4  -----------------                   
                  
                   *
                  **
                 ***
                ****
               *****
              ******
             *******
            ********


            for(int row = 1; row <= 8; row++)
            {
                for(int space = 1; space <= 8-row; space++)
                {
                    Console.Write(" ");
                }
                for(int column = 1; column <= row; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();

            */


            /* -----------------  Pattern 2.5  -----------------          

            * *
            ** **
            *** ***
            **** ****
            ***** *****
            ****** ******
            ******* *******


            for(int row = 1; row <= 7; row++)
            {
                for(int column = 1; column <= row; column++)
                {
                    Console.Write("*");
                }

                Console.Write(" ");

                for(int column = 1; column <= row; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();

            */


            /* -----------------  Pattern 2.6  -----------------           

            *******
            *     *
            *     *
            *     *
            *     *
            *     *
            *******


            for(int row = 1; row <= 1; row++)
            {
                for(int column = 1; column <= 7; column++)
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();

            for(int row = 1; row <= 5; row++)
            {
                for(int column = 1; column <= 1; column++)
                {
                    Console.Write("*     *");
                }
                Console.WriteLine();
            }

            for(int row = 1; row <= 1; row++)
            {
                for(int column = 1; column <= 7; column++)
                {
                    Console.Write("*");
                }
            }
            Console.Read();

            */


            /* -----------------  Pattern 2.7  -----------------
            
            *       *****************       *
            **      ********  *******      **
            ***     *******    ******     ***
            ****    ******      *****    ****
            *****   *****        ****   *****
            ******  ****          ***  ******
            ******* ***            ** *******
            **********              *********
                  
            
            for(int row = 1; row <= 8; row++)
            {
                for(int column = 1; column <= row; column++)      // first
                {
                    Console.Write("*");
                }

                for(int space = 1; space <= 8-row; space++)       // second
                {
                    Console.Write(" ");
                }
                for(int column = 1; column <= 10-row; column++)
                {
                    Console.Write("*");
                }
              
                for(int spaceTwo = 1; spaceTwo <= (row-1)*2; spaceTwo++)   // third
                {
                    Console.Write(" ");
                }
                for(int column = 1; column <= 9-row; column++)
                {
                    Console.Write("*");
                }          
                
                for(int space = 1; space <= 8-row; space++)   // fourth
                {
                    Console.Write(" ");
                }
                for(int column = 1; column <= row; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();

            */


            /* -----------------  Pattern 3.2  -----------------
             
               1
              212
             32123
            4321234
             32123
              212
               1
            

            for(int row = 1; row <= 4; row++)
            {
                for(int space = 1; space <= 4-row; space++)
                {
                    Console.Write(" ");
                }
                for(int column = row; column >= 1; column--)
                {
                    Console.Write(column);
                }
                for(int column = 1; column <= row-1; column++)
                {
                    Console.Write(column+1);
                }
                Console.WriteLine();
            } 

            for(int row = 1; row <= 3; row++)
            {
                for(int space = 1; space <= row; space++)
                {
                    Console.Write(" ");
                }
                for(int column = 4-row; column >= 1; column--)
                {
                    Console.Write(column);
                }
                for(int column = 1; column <= 3-row; column++)
                {
                    Console.Write(column+1);
                }
                Console.WriteLine();
            }
            Console.Read();

            */


            /* -----------------  Pattern 3.3  -----------------  
             
                  A
                 B B  
                C   C
               D     D
              E       E
             F         F
            G           G
             F         F
              E       E
               D     D
                C   C
                 B B
                  A
            

            char a = 'A';
            char b = 'B';
            char c = 'F';
            char d = 'F';

            for(int row = 1; row <= 7; row++)
            {
                for(int space = 1; space <= 7-row; space++)
                {
                    Console.Write(" ");
                }
                for(int column = 1; column <= 1; column++)
                {
                    Console.Write(a++);
                }     

                for(int space = 1; space <= (row*2)-3; space++)
                {
                    Console.Write(" ");
                }
                for(int column = 1; column <= row-1; column++)
                {
                    Console.Write(b++);
                    break;
                } 
                Console.WriteLine();
            }

            for(int row = 1; row <= 6; row++)
            {
                for(int space = 1; space <= row; space++)
                {
                    Console.Write(" ");
                }
                for(int column = 1; column <= 1; column++)
                {
                    Console.Write(c--);
                }

                for(int space = 1; space < ((5-row)*2+2); space++)
                {
                    Console.Write(" ");
                }
                for(int column = 1; column <= 6-row; column++)
                {
                    Console.Write(d--);
                    break;
                }
                Console.WriteLine();
            }
            Console.Read();
            
            */


            /* -----------------  Pattern 4.1  -----------------
            
                     0
                    1 1
                   2 2 2 
                  3 3 3 3
                 4 4 4 4 4
                5 5 5 5 5 5  
               6 6 6 6 6 6 6
              7 7 7 7 7 7 7 7
             8 8 8 8 8 8 8 8 8
            9 9 9 9 9 9 9 9 9 9


            for(int row = 1; row <= 10; row++)
            {
                for(int space = 1; space <= 10-row; space++)
                {
                    Console.Write("  ");
                }
                for(int column = 1; column <= row; column++)
                {
                    Console.Write("{0,4}", row-1);
                }
                Console.WriteLine();
            }
            Console.Read();            

            */


            /* -----------------  Pattern 4.6  -----------------
            
            987654321
            98765432
            9876543
            987654
            98765
            9876
            987
            98
            9


            for(int row = 1; row <= 9; row++)
            {
                for(int column = 1; column <= 10-row; column++)
                {
                    Console.Write(10-column);
                }
                Console.WriteLine();
            }
            Console.Read();

            */


            /* -----------------  Pattern 4.9  -----------------

            *********
             ******* 
              *****
               ***
                *
               ***
              *****
             ******* 
            *********
             

            for(int row = 5; row >= 1; row--)
            {
                for(int space = 1; space <= 5-row; space++)
                {
                    Console.Write(" ");
                }
                for(int column = 1; column <= (row*2)-1; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int row = 1; row <= 4; row++)
            {
                for(int space = 1; space <= 4-row; space++)
                {
                    Console.Write(" ");
                }
                for(int column = 1; column <= (row*2)+1; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();

            */
        }
    }
}