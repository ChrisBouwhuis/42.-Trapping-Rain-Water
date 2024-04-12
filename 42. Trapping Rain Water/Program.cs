using ClassLib;
namespace _42._Trapping_Rain_Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int result = solution.Trap(height);
            Console.WriteLine(result);
        }
    }
}
