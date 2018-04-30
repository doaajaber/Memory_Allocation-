using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication14
{
   public class Process
    {
        public int Process_size, p_start_address, End_p_address;
        public string process_name;

      
        //constructor
       public Process(int p_size, string pname)
        {
            Process_size = p_size;
            process_name = pname;
            End_p_address = p_start_address + Process_size; 
        }
    }
}
