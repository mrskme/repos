using System;

namespace Passordgenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersArgs = Console.ReadLine();
            string stringArgs = Console.ReadLine();
            args = new[] { numbersArgs, stringArgs };
            if (!IsValid(args))
            {
                ShowHelpText();
                return;
            }
            var numberStringArgs = Convert.ToInt32(args[0]);
            var finalStringArgs = args[1];
            var pattern = finalStringArgs.PadRight(numberStringArgs, 'l');
            while (pattern.Length > 0)
            {
                WriteRandomLowerCaseLetter();
                WriteRandomUpperCaseLetter();
                WriteRandomDigit();
                WriteRandomSpecialCharacter();
            }
        }
        static bool IsValid(string[] args)
        {
            if (IsValidNumbers(args)) 
            { 
                if (IsValidString(args))
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsValidNumbers(string[] args)
        {
            if (args.Length == 2)
            {
                return int.TryParse(args[0], out _);
            }
            return false;
        }
        static bool IsValidString(string[] args)
        {
            foreach (var character in args[1])
            {
                const string validCharacters = "lLds";
                //return !validCharacters.Contains(character);
                if (!validCharacters.Contains(character))
                {
                    return false;
                }
            }
            return true;
        }
        
        static void ShowHelpText() 
        {
            Console.Write("- l = lower case letter \n- L = upper case letter \n- d = digit \n- s = special character (!\"#¤%&/(){}[]\n");
            Console.Write("\tExample: PasswordGenerator 14 lLssdd \n\tMin. 1 lower case \n\tMin. 1 upper case \n\t2 special characters\n\tMin. 2 digits");
        }

    }
}
