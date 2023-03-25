class Program
{
    static void Main() //método main é o primeiro método que vai ser executado pelo runtime do dotnet e ele PRECISA ser um método estatico
  {
    BankAccount account1 = new BankAccount();
account1.name = null;
account1.balance = -100;
    BankAccount account2 = new BankAccount();

  }
}

class BankAccount
{
    private string name;//tipo e nome do campo, seu identificador
    private decimal balance;

    public BankAccount(string name, decimal balance)
    {
      if(string.IsNullOrWhiteSpace(name))
      {
        throw new ArgumentException("Nome inválido", "name");
      }
      if (balance < 0)
      {
        throw new ArgumentException("Saldo não pode ser negativo");
      }
      this.name = name;
      this.balance = balance;
    }

}
