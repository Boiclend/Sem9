int Zapros(string message) {
    Console.WriteLine(message);
    int num = System.Convert.ToInt32(Console.ReadLine());
    return num;
}

int number1 = Zapros("Введите число 1");
int number2 = Zapros("Введите число 2");
GetResult(number1,number2);
void GetResult(int num1, int num2)
{
    int summ = 0;
   for (int i = 0; i <= 15; i++)
   {
        if(num1 > num2) {
            Console.WriteLine(summ);
            return;
        } else {
            summ = summ + num1;
        }
        num1++;
   }
  
}
