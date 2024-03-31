namespace Task30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте в папке проекта файл Account.cs, и создайте в нём новый public класс Account. 
             * Добавьте в класс поле _balance. Поле пометьте модификатором private. 
             * Добавьте и реализуйте три метода: AddMoney, TakeMoney, ShowBalance. 
             * Метод AddMoney увеличивает значение _balance на указанное значение. 
             * Метод TakeMoney уменьшает значение _balance на указанную сумму. 
             * Метод ShowBalance возвращает значение _balance. Учтите, что ни в одном из методов не должно быть работы с консолью.*/


            Account account = new Account(_balance: 100000, add_sum: 15000);

            Console.WriteLine(Account.Sum);




            Console.ReadLine();

        }
        
    }
}
