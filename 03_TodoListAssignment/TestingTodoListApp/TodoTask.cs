using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestingTodoListApp
{
    public class TodoTask 
    {

        public int? m_id { get; set; } 
        public bool? m_done { get; set; } 
        public string? m_desc { get; set; }
        
        public override string ToString()
        {
            return $"Id: {m_id} + Task: {m_desc} + Did you do it?: {m_done}";
        }
        
        public TodoTask() { }

        public TodoTask(string desc)
        {
            m_desc = desc;
        }

        public TodoTask(bool done, string desc)
        {
            m_done = done;
            m_desc = desc;
        }

        public TodoTask(int id, bool done, string desc) 
        { 
            m_id = id ;
            m_done = done ;
            m_desc = desc ;
        }
    }

}





