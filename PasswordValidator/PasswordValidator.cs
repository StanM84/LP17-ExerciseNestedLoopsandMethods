string password = Console.ReadLine();

bool validLength = password.Length >= 6 && password.Length <= 10;
bool validContent = CheckContent(password);
bool validDigit = CheckCount(password);

if (validLength == true && validContent == true && validDigit == true)
{
    Console.WriteLine("Password is valid");
}
else
{
    if (validLength == false)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }

    if (validContent == false)
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }

    if (validDigit == false)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}

static bool CheckContent (string password)
{
    for (int position = 0; position <= password.Length-1; position++)
    {
        char c = password[position];

        if (char.IsLetterOrDigit(c) == false)
        {
            return false;
        }
    }
    return true;
}

static bool CheckCount (string password)
{
    int count = 0;

    for (int position = 0; position <= password.Length-1; position++) 
    {
        char c = password[position];
        if (char.IsDigit(c) == true)
        {
            count++;
        }
    }
    return count >= 2;
}