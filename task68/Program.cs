int Zapros(string message) {
    Console.WriteLine(message);
    int num = System.Convert.ToInt32(Console.ReadLine());
    return num;
}

int akkerman(int m, int n)
{
if (m == 0) {
    return n + 1;
} else if (n == 0){
    return akkerman(m - 1, 1);
} else {
    return akkerman(m - 1, akkerman(m, n - 1));
}
}



int num1 = Zapros("Введите число M");
int num2 = Zapros("Введите число N");
Console.Write($"Функция Аккермана равно {akkerman(num1, num2)} ");