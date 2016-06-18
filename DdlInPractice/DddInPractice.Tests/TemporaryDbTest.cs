using DddInPractice.Logic;
using Xunit;
using static DddInPractice.Logic.Money;

namespace DddInPractice.Tests
{
    public class TemporaryDbTests
    {
        [Fact]
        public void Test()
        {
            SessionFactory.Init(@"Server=.\SQLEXPRESS;Database=DddInPractice;Trusted_Connection=true");

            var repository = new SnackMachineRepository();

            var snackMachine = repository.GetById(1);

            snackMachine.InsertMoney(Dollar);
            snackMachine.InsertMoney(Dollar);
            snackMachine.InsertMoney(Dollar);
            snackMachine.BuySnack(1);

            repository.Save(snackMachine);
        }
    }
}