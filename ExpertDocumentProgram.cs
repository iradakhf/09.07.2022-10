using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class ExpertDocumentProgram :  ProDocumentProgram
    {

        public override void EditDocument()
        {
            Console.WriteLine("Document Edited");
           
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
         
    }
}
