namespace _8
{
    class BankAccount
    {
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string name, decimal startBalance)
        {
            OwnerName = name;
            Balance = startBalance;
        }

        public void TransferMoney(BankAccount destinationAccount, decimal amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
                destinationAccount.Balance += amount;
                Console.WriteLine($"Успешно переведено {amount} руб. от {this.OwnerName} к {destinationAccount.OwnerName}");
            }
            else
            {
                Console.WriteLine($"Ошибка! У {this.OwnerName} недостаточно средств для перевода {amount} руб.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount firstAccount = new BankAccount("Иван", 1000);
            BankAccount secondAccount = new BankAccount("Мария", 500);
            Console.WriteLine("Исходные балансы:");
            Console.WriteLine($"{firstAccount.OwnerName}: {firstAccount.Balance} руб.");
            Console.WriteLine($"{secondAccount.OwnerName}: {secondAccount.Balance} руб.");
            Console.WriteLine("------------------------------------------------");
            firstAccount.TransferMoney(secondAccount, 300);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Балансы после перевода:");
            Console.WriteLine($"{firstAccount.OwnerName}: {firstAccount.Balance} руб.");
            Console.WriteLine($"{secondAccount.OwnerName}: {secondAccount.Balance} руб.");
            Console.WriteLine("------------------------------------------------");
            firstAccount.TransferMoney(secondAccount, 2000);
        }
    }
}