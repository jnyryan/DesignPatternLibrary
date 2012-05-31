using System;
using System.Collections.Generic;
using System.Text;

/* 
 * What is a Bridge pattern
 * Gang of Four says "Decouple and abstraction from its implementation so the two can vary independently"
 *
 *What is an abstraction? 
 * An abstraction is a way of classifing a group of things or something that exists in our problem domain or code
 * it might be a base class or interface we use to a abstract away the concept of something that may have different implementations
 * 
 * Since the abstraction and implementation are by default coupled, the bridge pattern tries to decople the two  
 * so the two can vary independently
 */
namespace BridgePatternApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var docs = new List<Manuscript>();
                var standardFormatter = new StandardFormatter();
                var htmlFormatter = new HtmlFormatter();
                var reverseFormatter = new ReverseFormatter();

                var book = new Book(standardFormatter)
                               {
                                   Title = "Creating Design Pattern Code",
                                   Author = "John Ryan",
                                   Description = "My first book"

                               };
                docs.Add(book);

                var magazine = new Magazine(htmlFormatter)
                                   {
                                       Title = "Under the hood",
                                       Publisher = "Hot Code Press",
                                       Description = "A first look at Creating Design Pattern Code"
                                   };
                docs.Add(magazine);

                var newspaper = new Paper(reverseFormatter)
                                    {
                                        Title = "Inside the code",
                                        Publisher = "Independent News Corp Firm Ltd",
                                        Description = "An article about pretty ones and zeros"
                                    };
                docs.Add(newspaper);

                foreach (var manuscript in docs)
                {
                    manuscript.Print();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nHit any key to exit");
                Console.ReadKey();
            }
        }
    }
}
