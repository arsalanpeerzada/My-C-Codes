using System;

public class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("\t\t\t*************************************");
        Console.WriteLine("\n\t\t\tWelcome! :\n");
        Console.WriteLine("\n\t\t\tThis is a Matrix Operation Program\n");
        Console.WriteLine("\t\t\t ************************************");
        Console.ReadLine();




        Console.WriteLine("\n\nEnter the number of rows and columns of matrix: \n");
        Console.WriteLine("[Number of Rows]: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("[Number of Columns]: ");
        int n = Convert.ToInt32(Console.ReadLine());
    


        int[,] first = new int[m, n];
        int[,] second = new int[m, n];
        int[,] sum = new int[m, n];
        int[,] minus = new int[m, n];
        int[,] multiple = new int[m, n];
        int[,] transpose = new int[m, n];
        int[,] trans=new int[m,n];

        Console.WriteLine();

        Console.Write("Enter the elements of first matrix: \n");

        for (int c = 0; c < first.GetLength(0); c++)
        {
            for (int d = 0; d < first.GetLength(1); d++)
            {
                Console.Write("\t");
                first[c, d] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }


        Console.WriteLine("Enter the elements of second matrix: \n");

        for (int c = 0; c < second.GetLength(0); c++)
        {
            for (int d = 0; d < second.GetLength(1); d++)
            {
                Console.Write("\t");
                second[c, d] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        char z, ans;

        do
        {
            Console.Write("\t \t Press m/M FOR Multiplication: \n  \t \t Press s/S FOR Subtraction: \n \t \t Press a/A FOR Addation: \n \t \t Press t/T FOR First Matrix Transpose: \n \t \t Press r/R FOR Second Matrix Transpose: ");
            z = Convert.ToChar(Console.ReadLine());

            if (z == 'a' || z == 'A')
            {

                for (int c = 0; c < first.GetLength(0); c++)
                {
                    for (int d = 0; d < second.GetLength(1); d++)
                    {
                        sum[c, d] = first[c, d] + second[c, d];
                    }
                }


                Console.WriteLine("\t \tSum of entered matrices: \n");

                for (int c = 0; c < first.GetLength(0); c++)
                {

                    for (int d = 0; d < second.GetLength(1); d++)
                    {

                        Console.Write(sum[c, d] + "\t");
                        //Console.WriteLine("\t");
                    }
                    Console.WriteLine();
                }
            }

            else if (z == 's' || z == 'S')
            {

                for (int c = 0; c < first.GetLength(0); c++)
                {
                    for (int d = 0; d < second.GetLength(1); d++)
                    {
                        minus[c, d] = first[c, d] - second[c, d];
                    }
                }

                Console.WriteLine("\t \t Subtraction of Entered Matrices: \n");

                for (int c = 0; c < first.GetLength(0); c++)
                {

                    for (int d = 0; d < second.GetLength(1); d++)
                    {
                        Console.Write(minus[c, d] + "\t");
                        //Console.WriteLine("\t");
                    }
                    Console.WriteLine();
                }

            }
            else if (z == 'M' || z == 'm')
            {
                if(m==n){
                for (int c = 0; c < first.GetLength(0); c++)
                {
                    for (int d = 0; d < second.GetLength(1); d++)
                    {
                        multiple[c, d] = 0;
                        for (int k = 0; k < m; k++)
                        {
                            multiple[c, d] += first[c, k] * second[k, d];
                        }
                    }
                }



                Console.WriteLine("\t \tMultiplication of Entered Matrices: \n");


                for (int c = 0; c < first.GetLength(0); c++)
                {
                    for (int d = 0; d < second.GetLength(1); d++)
                    {
                        Console.Write(multiple[c, d] + "\t");
                    }
                    Console.WriteLine();
                }
             }else{
                Console.WriteLine("Multiplication cant be done !! plz enter equal row and column ! ");
             }
            }

            else if (z == 't' || z == 'T')
            {
                if (m < n)
                {
                    for (int c = 0; c < first.GetLength(0) + 1; c++)
                    {
                        for (int d = 0; d < first.GetLength(1) - 1; d++)
                        {
                            {
                                transpose[d, c] = first[d, c];

                            }
                        }
                    }



                    Console.WriteLine("\t\tTranspose of Entered Matrices: \n");


                    for (int c = 0; c < first.GetLength(0) + 1; c++)
                    {
                        for (int d = 0; d < first.GetLength(1) - 1; d++)
                        {
                            Console.Write(transpose[d, c] + "\t");


                            //Console.WriteLine("\t");
                        }
                        Console.WriteLine();
                    }
                }
                else if (m > n)
                {
                    for (int c = 0; c < first.GetLength(0) - 1; c++)
                    {
                        for (int d = 0; d < first.GetLength(1) + 1; d++)
                        {
                            {
                                transpose[d, c] = first[d, c];

                            }
                        }
                    }



                    Console.WriteLine("\t\tTranspose of Entered Matrices: \n");


                    for (int c = 0; c < first.GetLength(0) - 1; c++)
                    {
                        for (int d = 0; d < first.GetLength(1) + 1; d++)
                        {
                            Console.Write(transpose[d, c] + "\t");


                            //Console.WriteLine("\t");
                        }
                        Console.WriteLine();
                    }

                }
                else if (m == n)
                {
                    for (int c = 0; c < first.GetLength(0); c++)
                    {
                        for (int d = 0; d < first.GetLength(1); d++)
                        {
                            {
                                transpose[d, c] = first[d, c];

                            }
                        }
                    }



                    Console.WriteLine("\t\tTranspose of Entered Matrices: \n");


                    for (int c = 0; c < first.GetLength(0); c++)
                    {
                        for (int d = 0; d < first.GetLength(1); d++)
                        {
                            Console.Write(transpose[d, c] + "\t");


                            //Console.WriteLine("\t");
                        }
                        Console.WriteLine();
                    }
                }


            }


            else if (z == 'r' || z == 'R')
            {
                if (m < n)
                {
                    for (int c = 0; c < second.GetLength(0) + 1; c++)
                    {
                        for (int d = 0; d < second.GetLength(1) - 1; d++)
                        {
                            {
                                trans[d, c] = second[d, c];

                            }
                        }
                    }



                    Console.WriteLine("\t\tTranspose of Entered Matrices: \n");


                    for (int c = 0; c < second.GetLength(0) + 1; c++)
                    {
                        for (int d = 0; d < second.GetLength(1) - 1; d++)
                        {
                            Console.Write(trans[d, c] + "\t");


                            //Console.WriteLine("\t");
                        }
                        Console.WriteLine();
                    }
                }
                else if (m > n)
                {
                    for (int c = 0; c < second.GetLength(0) - 1; c++)
                    {
                        for (int d = 0; d < second.GetLength(1) + 1; d++)
                        {
                            {
                                trans[d, c] = second[d, c];

                            }
                        }
                    }



                    Console.WriteLine("\t\tTranspose of Entered Matrices: \n");


                    for (int c = 0; c < second.GetLength(0) - 1; c++)
                    {
                        for (int d = 0; d < second.GetLength(1) + 1; d++)
                        {
                            Console.Write(trans[d, c] + "\t");


                            //Console.WriteLine("\t");
                        }
                        Console.WriteLine();
                    }

                }
                else if (m == n)
                {
                    for (int c = 0; c < second.GetLength(0); c++)
                    {
                        for (int d = 0; d < second.GetLength(1); d++)
                        {
                            {
                                trans[d, c] = second[d, c];

                            }
                        }
                    }



                    Console.WriteLine("\t\tTranspose of Entered Matrices: \n");


                    for (int c = 0; c < second.GetLength(0); c++)
                    {
                        for (int d = 0; d < second.GetLength(1); d++)
                        {
                            Console.Write(trans[d, c] + "\t");


                            //Console.WriteLine("\t");
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("\nDo you want to solve another matrix?\n");
            Console.WriteLine("[Y/y] or [N/n]: ");
            ans = Convert.ToChar(Console.ReadLine());



        } while (ans == 'y' || ans == 'Y');
    }






}