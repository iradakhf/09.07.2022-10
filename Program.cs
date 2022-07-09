using System;
namespace ConsoleApp17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            string word = "pro";


            ProDocumentProgram pro = new ProDocumentProgram();//pro sozune uygun muvafiq obyekt pro
            ExpertDocumentProgram expert = new ExpertDocumentProgram();
            DocumentProgram basic = new DocumentProgram();
            
            
           
                if (word=="pro")
                {
                    pro.OpenDocument();
                    pro.EditDocument();
                    pro.SaveDocument();
                    
                }
                else if (word=="basic")
                {
                    basic.OpenDocument();
                    basic.EditDocument();
                    basic.SaveDocument();
                    
                }
                else if (word=="expert")
                {
                     expert.OpenDocument();
                    expert.EditDocument();
                    expert.SaveDocument();
                    
                }
            else
            {
                Console.WriteLine("none");
            }
             



        }
    }
}
