namespace _0418_S4_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> charList = [];

            charList.Add('Y');
            charList.Add('E');
            charList.Add('S');

            DisplayCharList(charList);

            // Remove first character
            charList.RemoveAt(0);
            DisplayCharList(charList);

            // Remove third character
            charList.Remove('S');
            DisplayCharList(charList);

            // Modify second character
            // (positiion 0 since first character removed)
            charList[0] = 'A';
            DisplayCharList(charList);
        }

        static void DisplayCharList(List<char> charList)
        {
            foreach(char c in charList)
                Console.Write(c);
            Console.WriteLine();
        }
    }
}
