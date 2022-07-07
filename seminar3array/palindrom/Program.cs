//палиндром
int reversNumber(int number)
{
    int reversedNumber = new int();
    while (number > 0)
    {
        reversedNumber = number % 10 + reversedNumber * 10;
        number /= 10;
    }
    return reversedNumber;
}
bool IsPalindrome(int number)
{
    bool isPalindrome = false;
    if(number != 0)
    {
        number = Math.Abs(number);
        int reversedNumber = reversNumber(number);
        isPalindrome = (number == reversedNumber);
    }
    else
    {
        Console.WriteLine("Число должно быть не равно нулю");
    }
    return isPalindrome;
}
Console.WriteLine("Введите число для палиндрома");
int userNumber = Convert.ToInt32(Console.ReadLine());
bool isPalindrome = IsPalindrome(userNumber);
string isPalindromeStr = (isPalindrome) ? "" : "не";
Console.WriteLine($"Число {isPalindromeStr} {userNumber} является палиндромом");