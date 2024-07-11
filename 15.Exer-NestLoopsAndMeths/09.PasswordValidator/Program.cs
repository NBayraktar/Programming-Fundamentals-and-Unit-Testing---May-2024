namespace _09.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a string from the console (password)
            string password = Console.ReadLine();

            // Check if password is valid and print the corresponding message to the console
            bool isValidLength = password.Length >= 6 && password.Length <= 10;
            bool isValidContent = CheckContent(password);
            bool isValidCountDigits = CheckCount(password);

            if (isValidLength && isValidContent && isValidCountDigits)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (isValidLength == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (isValidContent == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (isValidCountDigits == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }

            }
        }
        static bool CheckContent(string pass)
        {
            for (int position = 0; position <= pass.Length - 1; position++)
            {
                char symbol = pass[position];
                if (char.IsLetterOrDigit(symbol) == false)
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckCount(string pass)
        {
            int count = 0;
            for (int position = 0; position <= pass.Length - 1; position++)
            {
                char symbol = pass[position];
                if (char.IsDigit(symbol) == true)
                {
                    count++;
                }
            }
            return count >= 2;
        }
    }
}
