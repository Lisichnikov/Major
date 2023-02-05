
namespace major
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[1000];
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(1, 100);
            // создаю рандомный массив
            Array.Sort(array);
            // сортирую
            int maxCount = -1, maxCountKey = 0, currCount = 0, currCountKey = array[0];
            /* maxCount - количество повторов мажоритарного числа
             * maxCountKey - мажоритальное число
             * currCount - текущее количество повторов мажоритарного числа
             * currCountKey - текущее мажоритальное число
             */
            foreach (int i in array)
            {
                if (i == currCountKey)
                {
                    currCount++;
                }
                // если элемент массива ровняется текущему мажоритальному числу увеличиваем количество повторов на 1
                else
                {
                    currCount = 1;
                    currCountKey = i;
                }
                // если нет то текущее мажоритальное число ровняется новому числу и количество повторов становится равным единице
                if (currCount > maxCount)
                {
                    maxCount = currCount;
                    maxCountKey = i;
                }
                /* если текущее количество повторов мажоритарного числа становится больше количества повторов мажоритарного числа,
                 * оно становится текущим количеством повторов мажоритального числа и мажоритальное число становится равным
                 * текущему элементу массива
                 */
            }
            Console.WriteLine($"Число, которое больше всего повторяется: " + maxCountKey + ". Количество его повтора:" + maxCount);
        }
    }
}