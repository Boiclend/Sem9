int Zapros(string message) {
    Console.WriteLine(message);
    int num = System.Convert.ToInt32(Console.ReadLine());
    return num;
}

int number = Zapros("Введите число");
int prompt = 1;
GetResult(number, prompt);
void GetResult(int num, int Prompt)
{
    if (Prompt > num)
    {
        return;
    }
    else
    {
        GetResult(num, Prompt + 1);
        Console.Write(Prompt + " ");
    }
}



