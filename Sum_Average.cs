public class Sum_Average
{
    static void Main()
    {
        int size;
        int sum = 0;
        float avg = 0;
        Console.WriteLine("Enter size of Array");
        size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter Numbers");
        for(int y = 0;y < size; y++)
        {
            arr[y] = int.Parse(Console.ReadLine());
        }
        for(int i =0;i<size;i++)
        {
            sum+= arr[i];
            avg = sum / size;

        }
        Console.WriteLine($"Sum of Array is {sum}");
        Console.WriteLine($"Average of Array is {avg}");

    }
}