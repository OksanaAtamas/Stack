namespace Lesson_2
{
    class Stack
    {
        private string[] stackArray;
        private int index;
        private int count;

        public Stack(int size)
        {
            stackArray = new string[size];
            index = -1;
            count = 0;
        }

        public void Push(string item) //метод додавання
        {
            if (index == stackArray.Length - 1)
            {
                Console.WriteLine("Переповнено");
                return;
            }
            Console.WriteLine(stackArray[++index] = item);
            count++;
            //Console.WriteLine( count);
            // Console.WriteLine( index);
        }

        public string Pop()//метод видалення
        {
            if (index == -1)
            {
                Console.WriteLine("Порожньо");
                return "";
            }
            count--;
            //Console.WriteLine( count);
            //Console.WriteLine( index);
            return stackArray[index--];

        }


        public string Peek()//повертає останній елемент
        {
            if (index == -1)
            {
                Console.WriteLine("Порожньо");
                return "";
            }
            return stackArray[index];
        }

        public int Count
        {
            get { return count; }
        }

        public void Clear()//очищає
        {
            Array.Clear(stackArray, 0, stackArray.Length);
            index = -1;
            count = 0;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Stack myStack = new Stack(3);

            myStack.Push("замовлення 1");
            myStack.Push("замовлення 2");
            myStack.Push("замовлення 3");
            Console.WriteLine("Кількість після додавання: " + myStack.Count);
            Console.WriteLine("Останнє замовлення: " + myStack.Peek());
            Console.WriteLine("Видаляємо останнєзамовлення: " + myStack.Pop());
            Console.WriteLine("Кількість після видалення: " + myStack.Count);
            Console.WriteLine("Замовлення після видалення: ");
            for (int i = myStack.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(myStack.Pop());
            }
            myStack.Clear();
            Console.WriteLine("Кількість після видалення: " + myStack.Count);

            Console.ReadLine();

        }

    }
}
