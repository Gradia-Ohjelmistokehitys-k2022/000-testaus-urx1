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
    -Poista teht‰v‰ listasta. Toimiiko laskuri oikein?
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
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TestingTodoListApp;
using TodoListNS;

namespace TodoTests
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void Test_AddItemToList()
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
    }
}