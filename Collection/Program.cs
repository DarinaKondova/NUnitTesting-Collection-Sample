using Collections;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection=new Collection<int>();
            Console.WriteLine("Current collection: " + collection.ToString());

            Console.WriteLine("Collection count: " + collection.Count);
            Console.WriteLine("Collection capacity: " + collection.Capacity);

            collection.Add(5);// добавяме един елемент 5 и това ни е първия елемент
            Console.WriteLine("Current collection: " + collection.ToString()); 

            collection.AddRange(6,7);// добавяме рейндж от 6 и7 т.е. към 5 добавяме 6 и 7 и става [5,6,7]
            Console.WriteLine("Current collection: " + collection.ToString());

            Console.WriteLine("Print the first element: " + collection[0]);//принтира първия елемент т.е 5

            collection[0] = 55; //първия елемент става равен на 55 т.е 5 се заменя от 55
            Console.WriteLine("Print the first element: " + collection[0]);//принтира първия елемент, който вече е 55

            collection.InsertAt(2, 666); //вмъкваме трети елемент, който е равен на 666 /между 6 и 7/ става [55, 6, 666,7]
            Console.WriteLine("Current collection: " + collection);

            collection.Exchange(1, 2); //  да се разменят втори и трети елемент,защото започваме от нулев т.е.
            //[55,6,666,7] ЩЕ стане [55,666,6,7]
            Console.WriteLine("Current collection: " + collection);

            collection.Clear(); // да зачисти колекцията ще изведе резултат []
            Console.WriteLine("Current collection: " + collection);





        }
    }
}