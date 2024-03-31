// Создайте в папке проекта файл Account.cs, и создайте в нём новый public класс Account. 

public class Account 
{
    //* Добавьте в класс поле _balance. Поле пометьте модификатором private. 

    private int _balance;

    public int Balance;
    public int Add_sum;
    public static int Sum = 0;

    /*Добавьте и реализуйте три метода: AddMoney, TakeMoney, ShowBalance.
    * Метод AddMoney увеличивает значение _balance на указанное значение. 
    * Метод TakeMoney уменьшает значение _balance на указанную сумму. 
    * Метод ShowBalance возвращает значение _balance. Учтите, что ни в одном из методов не должно быть работы с консолью.*/

    public AddMoney(int _balance, int add_sum) 
    {
        Balance = _balance;

        Add_sum = add_sum;

        Sum = _balance + add_sum;  


    }


}