/*
AddItemToList(TodoTask item) - metodin mahdolliset testit:
    -Lis‰‰ yksi teht‰v‰ listaan onnistuneesti.
    - Lis‰‰ useampi teht‰v‰ listaan. Kasvaako laskuri oikein?
    - Lis‰‰ teht‰vi‰ eri arvoilla.
    - Teht‰v‰, jossa on erikoismerkkej‰.
    - Mit‰ tapahtuu, jos lista on tyhj‰?
    - Voiko teht‰v‰/itemi olla tyhj‰?
    - Listassa on jo valmiita arvoja.
    - Voiko listan maksimi ylitty‰?
  
2. public void RemoveItemFromList(TodoTask item)-metodin mahdolliset testit:
    - Poista teht‰v‰ listasta. Toimiiko laskuri oikein?
    - Poista teht‰v‰ tyhj‰st‰ listasta.
    - Poista viimeinen teht‰v‰ listasta.
    - Poista tietty teht‰v‰ listasta.
    - Poista teht‰v‰, jota ei ole olemassa.
    - Poista useampi teht‰v‰ per‰kk‰in.

  
3. public void CompleteItem(int id)-metodin mahdolliset testit:
     -Merkitse teht‰v‰ tehdyksi id:n perusteella. 
     -Merkitse listan viimeinen teht‰v‰ tehdyksi.
     - Merkitse teht‰v‰, jota ei ole olemassa tehdyksi.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TestingTodoListApp;
using TodoListNS;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TodoTests
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void Test_AddItem()
        {
            int counter = 0;

            TodoList todoList = new();

            todoList.AddItemToList(new TodoTask("Test"));

            var list = todoList.All;

            foreach (var item in list)
            {
                counter++;
            }
            if (counter < 1)
            {
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => todoList.AddItemToList(new TodoTask("Test")));
            }
        }
        public void Test_AddItems()
        {
            int counter = 0;

            int expected = 3;

            TodoList todoList = new();

            todoList.AddItemToList(new TodoTask("Test"));
            todoList.AddItemToList(new TodoTask("Test2"));
            todoList.AddItemToList(new TodoTask("Test3"));

            var list = todoList.All;

            foreach (var item in list)
            {
                counter++;
            }
            if (counter != expected)
            {
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => counter);
                //Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => todoList.AddItemToList(new TodoTask("Test")));

            }
        }
        [TestMethod]
        public void Test_AddItems_WithDifferentValues()
        {
            int counter = 0;

            TodoList todoList = new();

            todoList.AddItemToList(new TodoTask("Test"));
            todoList.AddItemToList(new TodoTask(true, "Test2"));
            todoList.AddItemToList(new TodoTask(false, "Test3"));
            todoList.AddItemToList(new TodoTask(23, false, "Test4"));
            todoList.AddItemToList(new TodoTask());

            var list = todoList.All;

            foreach (var item in list)
            {
                counter++;
            }
            if (counter != 5)
            {
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => counter);
            }
        }
        [TestMethod]
        public void Test_AddItem_WithSpecialChars_ThrowsException()
        {
            bool HasSpecialChars(string yourString)
            {
                return yourString.Any(ch => !char.IsLetterOrDigit(ch));
            }


            TodoList todoList = new();

            todoList.AddItemToList(new TodoTask("asdf"));

            var list = todoList.All;

            foreach (var item in list)
            {
                if (item.m_desc.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                    Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => item.m_desc);
                }
            }
        }

        [TestMethod]
        public void Test_ListIsEmpty_ThrowsException()
        {

            TodoList todoList = new();

            todoList.AddItemToList(new TodoTask("asdf"));

            var list = todoList.All;

            bool isEmpty = !list.Any();

            if (isEmpty)
            {
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => isEmpty);
            }
        }

        [TestMethod]
        public void Test_ItemIsEmpty_ThrowsException()
        {

            TodoList todoList = new();

            todoList.AddItemToList(new TodoTask(1, false, "asdf"));

            var list = todoList.All;

            foreach (var item in list)
            {
               if (item.m_done is null || item.m_id is null || item.m_desc is null)
                {
                    Assert.ThrowsException<System.ArgumentNullException>(() => item);
                }
            }
        }

        [TestMethod]
        public void Test_AddItem_ListHasTrueTasks()
        {
            TodoList todoList = new();

            todoList.AddItemToList(new TodoTask(1, false, "asdf"));

            var list = todoList.All;

                todoList.AddItemToList(new TodoTask(2, false, "asdff"));

                foreach (var item in list)
                {
                    if (item.m_done is true)
                    {
                        throw new ArgumentOutOfRangeException("Can't add new item when list has item that is Done.");

                    }
                }            
        }
        //- Listassa on jo valmiita arvoja.
        [TestMethod]
        public void Test_AddItem_ListIsFull_ThrowsException()
        {
            int maxCap = 20; //oikea raja on 2gb dataa, luodaan omarajoite

            int counter = 0;

            TodoList todoList = new();

            todoList.AddItemToList(new TodoTask("asdf"));

            foreach (int value in Enumerable.Range(1,19))
            {
                counter++;
                todoList.AddItemToList(new TodoTask("asdf"));
            }

            var list = todoList.All;

            if (counter > 20)
            {
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => counter);
            }
        }

        [TestMethod]
        public void Test_AddItem_WithSameID_ThrowsException()
        {
            TodoList todoList = new();
            
            todoList.AddItemToList(new TodoTask(1, false, "asdf"));

            var list = todoList.All;
            
            todoList.AddItemToList(new TodoTask(2, false, "bˆˆ"));

            int counter = 0;

            List<int> checkList = new List <int>();
            checkList.Add(0);

            foreach (var item in list)
            {
                counter++;
                var itemToAdd = item.m_id.Value;
                checkList.Add(itemToAdd);
                if (item.m_id == checkList[counter-1])
                {
                    Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => item.m_id);
                }
            }
        }

        [TestMethod]
        public void Test_RemoveLastItem_Works()
        {
            TodoList todoList = new();
            
            todoList.AddItemToList(new TodoTask(false, "yksi"));
            todoList.AddItemToList(new TodoTask(false, "kaksi"));
            todoList.AddItemToList(new TodoTask(false, "kolme"));
            todoList.AddItemToList(new TodoTask(false, "nelj‰"));


            var list = todoList.All;

            todoList.RemoveLastItemFromList();

            foreach (var item in list)
            {
                if (item.m_desc == "nelj‰")
                {
                    throw new ArgumentException("Last item of list not deleted.");
                }
            }
        }

        [TestMethod]
        public void Test_RemoveItem_AtRightID()
        {

            int counter = 0;

            TodoList todoList = new();

            todoList.AddItemToList(new TodoTask(false, "asdf"));
            todoList.AddItemToList(new TodoTask(false, "aksdgjh"));
            todoList.AddItemToList(new TodoTask(false, "asdddddddf"));

            var list = todoList.All;

            foreach (var item in list)
            {
                counter++;
            }
        }

        [TestMethod]
        public void Test_RemoveItem_FromEmptyList_ThrowsException()
        {

            TodoList todoList = new();

            todoList.AddItemToList(new TodoTask("Terve"));

            var list = todoList.All;

            todoList.RemoveLastItemFromList();

            foreach (var item in list)
                if (item is null)
                {
                    throw new Exception("Item to delete does not exist, is list empty?");
                }
                else
                {
                    todoList.RemoveLastItemFromList();
                }
        }

        [TestMethod]
        public void Test_RemoveMultipleItems_WithDifferentFunctions_Works()
        { 
            TodoList todoList = new();

            todoList.AddItemToList(new TodoTask("Terve"));
            todoList.AddItemToList(new TodoTask(false, "Termos"));
            todoList.AddItemToList(new TodoTask("P‰iv‰‰"));

            var list = todoList.All;

            todoList.RemoveItemFromList(1);
            //todoList.RemoveLastItemFromList();

            foreach (var item in list)
            {
                if (item.m_id == 1 && item.m_id == 3)
                {
                    throw new Exception("All items not deleted");
                }
            }
        }

        [TestMethod]
        public void Test_CompleteItem_ById_Works()
        {
            TodoList todoList = new();

            todoList.AddItemToList(new TodoTask(1, false, "Terve"));
            todoList.AddItemToList(new TodoTask(2, false, "Termos"));
            todoList.AddItemToList(new TodoTask(3, false, "P‰iv‰‰"));

            var list = todoList.All;

            bool expected = true;

            todoList.CompleteItem(2);

            foreach (var item in list.Where(item => item.m_id == 2)) 
            { 
                if (item.m_done != expected)
                {
                    throw new Exception("Item not completed");
                }            
            }
        }
        [TestMethod]
        public void Test_CompleteItem_ThatDoesntExist()
        {
            var todoList = new TodoList();

            List<int> checkList = new List<int>();

            todoList.AddItemToList(new TodoTask(1, false, "Terve"));
            todoList.AddItemToList(new TodoTask(2, false, "Termos"));
            todoList.AddItemToList(new TodoTask(3, false, "P‰iv‰‰"));

            var list = todoList.All;

            int idToComp = 3;

            foreach (var item in list)
            {
                checkList.Add((int)item.m_id);
            }

                if (checkList.Contains(idToComp))
                {
                    todoList.CompleteItem(idToComp);

                }
                else
                {
                    Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => idToComp);
                }

            /*
            if (Enumerable.Range(0, list.Count()).Contains(idToComp))
            {
                todoList.CompleteItem(idToComp);
            }
            else
            {
                Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => idToComp);
            }
            */

        }
        [TestMethod]
        public void Test_CompleteItem_AlreadyCompleted_ThrowsError()
        {
            var todoList = new TodoList();

            List<int> checkList = new List<int>();

            todoList.AddItemToList(new TodoTask(1, false, "Terve"));
            todoList.AddItemToList(new TodoTask(2, false, "Termos"));
            todoList.AddItemToList(new TodoTask(3, true, "P‰iv‰‰"));

            var list = todoList.All;

            int idToComp = 2;



            foreach (var item in list.Where(item => item.m_id == idToComp))
            {
                if (item.m_done == true)
                {
                    throw new Exception("Item already marked as completed.");
                }
                else
                {
                    todoList.CompleteItem(idToComp);
                }
            }
        }

        /*
        3. public void CompleteItem(int id)-metodin mahdolliset testit:
        -Merkitse teht‰v‰ tehdyksi id:n perusteella. 
        -Merkitse listan viimeinen teht‰v‰ tehdyksi.
        - Merkitse teht‰v‰, jota ei ole olemassa tehdyksi.
        */

    }
}