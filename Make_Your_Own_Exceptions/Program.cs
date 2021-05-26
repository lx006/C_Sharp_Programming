using System;

namespace ExceptionClass
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age;
                string name;
                Console.WriteLine("Enter your age");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your name");
                name = Console.ReadLine();
                char[] spearator = { ' ' };
                Int32 count = 2;


                if (age <= 0 || age > 70)
                {
                    //AgeException ex = new AgeException();
                    // throw ex;

                    throw new AgeException();

                }
               
                String[] strlist = name.Split(spearator,count, StringSplitOptions.None);

                foreach (String s in strlist)
                {
                    int i = 0,k=0;
                    if(s[i]>='A'&& s[i]<='Z')
                    {
                        for(int j=1;j<s.Length;j++)
                        {
                            if(s[j]>='a'&&s[j]<='z')
                            {
                                k = 1;
                            }
                        }
                        if(k==1)
                        {
                            //Console.WriteLine(s + "Nice name");
                        }
                        else
                        {
                            NameException nm = new NameException();
                            throw nm;
                        }
                    }
                    else
                    {
                        NameException nm = new NameException();
                        throw nm;
                    }
                }

                if (age >= 18)
                {
                    Console.WriteLine("Hello " + name + "you Can vote");
                }
                else
                {
                    Console.WriteLine("cant vote");
                }


            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(NameException nm)
            {
                Console.WriteLine(nm.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
        
    
    }
}
