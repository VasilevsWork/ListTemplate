using System;
using System.Collections.Generic;
using System.Text;

namespace ListTemplate
{
    class MyList
    {
        // Узел списка
        private class Node
        {
            // Хранимые данные
            public MyPerson data;
            // Следующий элемент списка
            public Node next;
            // Предыдущий элемент списка
            public Node prev;
        }

        Node first = null;
        Node last = null;

        // Добавление в начало списка
        public void Append(MyPerson item)
        {

        }

        // Добавление в конец списка
        public void Prepend(MyPerson item)
        {

        }

        // Добавляет элемент на указанную позицию
        public void Insert(MyPerson item, int postion)
        {

        }

        // Удаляет элемент по указаннмоу ключу
        private void Remove(string keyValue)
        {

        }

        public MyPerson[] ToArray()
        {
            return new MyPerson[0];
        }

        // Ищет элемент списка по указанному ключу (имени)
        public MyPerson Find(string keyValue)
        {
            return new MyPerson();
        }

        // Поиск узла
        private Node FindNode(string keyValue)
        {
            return null;
        }


    }
}
