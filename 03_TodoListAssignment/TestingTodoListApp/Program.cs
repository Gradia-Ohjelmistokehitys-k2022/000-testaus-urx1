using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using TestingTodoListApp;


namespace TodoListNS
{

    /// <summary>
    /// Todo list. You can inserts things to do. Delete them. Complete them.
    /// </summary>
    public class Program
    {

        public static void Main()
        {
            TodoList todoList = new ();

            todoList.AddItemToList(new TodoTask("Do the dishes"));
          
            todoList.AddItemToList(new TodoTask("Wash your clothes"));
            todoList.AddItemToList(new TodoTask(false, "Minut tehdään kohta"));
            todoList.AddItemToList(new TodoTask("Minut poistetaan kohta"));
            var list = todoList.All; //for iterations
            //var anotherList = todoList._TodoItems; //original style of getting list
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString()); //vaihdettu suoraan ToString() koska recordit sallii toimivuuden näinkin
            }
            /*
            foreach (var item in anotherList)
            {
                Console.WriteLine(item.ToString());
            }
            
            //todoList.RemoveItemFromList(1);
            
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString()); //vaihdettu suoraan ToString() koska recordit sallii toimivuuden näinkin
            }

            todoList.CompleteItem(2);
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString()); //vaihdettu suoraan ToString() koska recordit sallii toimivuuden näinkin
            }
            */

            todoList.RemoveLastItemFromList();
            todoList.CompleteItem(3);

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString()); //vaihdettu suoraan ToString() koska recordit sallii toimivuuden näinkin
            }
        }

    }
}
