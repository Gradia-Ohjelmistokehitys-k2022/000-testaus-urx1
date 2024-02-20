using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestingTodoListApp
{
    public class TodoList
    {

        public List<TodoTask> _tasks;
        private int _taskCounter = 0;
        public IEnumerable<TodoTask> All => _TodoItems; //https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.all?view=net-6.0
        public List<TodoTask> _TodoItems { get => _tasks; }

        /// <summary>
        /// Each time new todolist is created. New list of tasks is created.
        /// </summary>
        public TodoList()
        {
            _tasks = new List<TodoTask>();
            //string defaultTask = $"Task number {_taskCounter}"; // remove
            //TodoTask item = new(defaultTask);
        }
        public void AddItemToList(TodoTask item)
        {
            if (item.m_id is null)
            {
                _taskCounter++;
                item.m_id = _taskCounter;
                _tasks.Add(item);
            }
            else
            _tasks.Add(item);
        }
        public void RemoveItemFromList(int idToRemove)
        {
            _tasks.RemoveAt(idToRemove-1); //miksei vaan näin???
            //taskcounter --???
            //LISÄÄ TÄHÄN SEMMONEN ETTÄ MUUTTAA YMPÄRÖIVIEN ID:T?
        }


        public void RemoveLastItemFromList()
        {
            if (_tasks.Count <= _taskCounter - 1)
            {
                throw new Exception("Error: Last item does not exist.");
            }
            else
            {
                _tasks.RemoveAt(_taskCounter - 1);
            }

        }

        public void CompleteItem(int id)
        {
            foreach(var task in _tasks) 
            { 
                if (task.m_id == id)
                {
                    task.m_done = true;
                }
            }
            /*
            // remove the item
            var item = _tasks.First(x => x.m_id == id); 
            RemoveItemFromList(id); //combine with removefromlist?
            */
        }
    }
}
