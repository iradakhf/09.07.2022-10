using System;
namespace ConsoleApp17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            string word = "pro";
            int i = 0;

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
                else
                {
                    basic.OpenDocument();
                    basic.EditDocument();
                    basic.SaveDocument();
                    
                }
             



        }
    }
}
