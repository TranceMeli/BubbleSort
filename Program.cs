namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erstellen Sie ein int Array mit den Werten 4, 33, 7, 1, 23, 12 in genau dieser Reihenfolge.
            //Schreiben Sie dann einen Bubblesort um die Zahlen aufsteigend, von der kleinsten bis zur größten Zahl, zu sortieren. 
            //Lassen Sie sich zur Kontrolle dann das sortierte Array ausgeben. 
            //Keine verwendung der .Sort() Methode oder ähnlichen Methoden sind zulässig!

            Console.WriteLine("BubbleSort");


            int[] numbers = new int[] { 4, 33, 7, 1, 23, 12 };
            int temp = 0;

            for (int i = 0; i <= numbers.Length - 1; i++) //checking first position in the array
            {
                for (int j = i + 1; j < numbers.Length; j++) //iterates the length of the array
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort in ascending order");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        
        }
    }
}