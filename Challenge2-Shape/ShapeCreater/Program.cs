using System;
using Challenge2_Shape;

namespace ShapeCreater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------This is Shape Gernerater-------");
            Console.WriteLine("Type [A] to create Square");
            Console.WriteLine("Type [B] to create Rectangle");
            Console.WriteLine("Type [C] to create Equailateral Triangle");
            Console.WriteLine("Type [D] to create RightAngle Triangle");
            Console.WriteLine("Type [E] to create Circle");


            string inputshape = Console.ReadLine().ToUpper();

            try
            {
                if (inputshape == "A")
                {
                    Console.WriteLine("You Selected Square, Please Type color for the shape");
                    string sqcolor = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("Please Type side lenght for the square");
                        int sqside1 = int.Parse(Console.ReadLine());

                        if (sqside1 < 1)
                        {
                            throw new LessThanOneExecption();
                        }

                        Square sq = new Square(Convert.ToDouble(sqside1), sqcolor);

                        Console.WriteLine("Your created a " + sqcolor +" Square with Sidelength: " + sqside1);
                        
                    }

                    catch (LessThanOneExecption e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Side Length cannot be less than 1");
                    }

                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Integer only for Side Length");
                    }

                   

                }

                else if (inputshape == "B")
                {
                    Console.WriteLine("You Selected Rectangle, Please Type color for the shape");
                    string recolor = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("Please Type side lenght 1 for the Rectangle");
                        int reside1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please Type side lenght 2 for the Rectangle");
                        int reside2 = int.Parse(Console.ReadLine());


                        Console.WriteLine();

                        if (reside1 < 1 || reside2<1)
                        {
                            throw new LessThanOneExecption();
                        }

                        

                        Rectangle re = new Rectangle(Convert.ToDouble(reside1),Convert.ToDouble(reside2), recolor);

                        Console.WriteLine("Your created a " + recolor + " Rectangle with Sidelength1: " + reside1  + " and Sidekenght2: " + reside2);

                    }

                    catch (LessThanOneExecption e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Side Length cannot be less than 1");
                    }

                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Integer only for Side Length");
                    }
                }

                else if (inputshape == "C")
                {
                    Console.WriteLine("You Selected Equailateral Triangle, Please Type color for the shape");
                    string eqcolor = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("Please Type side lenght for the Equailateral Triangle");
                        int eqside1 = int.Parse(Console.ReadLine());

                        if (eqside1 < 1)
                        {
                            throw new LessThanOneExecption();
                        }

                        Equilateral seq = new Equilateral(Convert.ToDouble(eqside1), eqcolor);

                        Console.WriteLine("Your created a " + eqcolor + " Equailateral Triangle with Sidelength: " + eqside1);

                    }

                    catch (LessThanOneExecption e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Side Length cannot be less than 1");
                    }

                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Integer only for Side Length");
                    }
                }

                else if (inputshape == "D")
                {
                    Console.WriteLine("You Selected RightAngle Triangle, Please Type color for the shape");
                    string ricolor = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("Please Type side lenght 1 for the RightAngle Triangle");
                        int riside1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please Type side lenght 2 for the RightAngle Triangle");
                        int riside2 = int.Parse(Console.ReadLine());

                        if (riside1 < 1)
                        {
                            throw new LessThanOneExecption();
                        }

                        Rightangle ri = new Rightangle(Convert.ToDouble(riside1), Convert.ToDouble(riside2), ricolor);

                        double riside3 = ri.Side3Length;

                        Console.WriteLine("Your created a " + ricolor + " RightAngle Triangle with Sidelength1 : " + riside1 + " and Sidelength2: " + riside2 + " and Sidelength3: " + riside3);

                    }

                    catch (LessThanOneExecption e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Side Length cannot be less than 1");
                    }

                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Integer only for Side Length");
                    }
                }

                else if (inputshape == "E")
                {
                    Console.WriteLine("You Selected Circle, Please Type color for the shape");
                    string cicolor = Console.ReadLine();
                    try
                    {
                        Console.WriteLine("Please Type side lenght for the Circle");
                        int radios = int.Parse(Console.ReadLine());

                        if (radios < 1)
                        {
                            throw new LessThanOneExecption();
                        }

                        Circle sq = new Circle(Convert.ToDouble(radios), cicolor);

                        Console.WriteLine("Your created a " + cicolor + " Circle with Radios: " + radios);

                    }

                    catch (LessThanOneExecption e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Side Length cannot be less than 1");
                    }

                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Integer only for Side Length");
                    }
                }

                else
                {
                    throw new InvaildInputException();
                }
            }

            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("This Generater only accept Letter to create shape ");
            }

            catch(InvaildInputException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("You Have to Type [A] ro [B] or [C] or [D] or [E] to create shape");
            }

           
            
        }
    }
}
