using DddInPractice.Logic.Management;
using DddInPractice.Logic.SnackMachines;
using DddInPractice.Logic.Utils;
using Xunit;
using static DddInPractice.Logic.SharedKernel.Money;

namespace DddInPractice.Tests
{
    public class TemporaryDbTests
    {
        [Fact]
        public void TestSnackMachineEntity()
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


        [Fact]
        public void TestHeadOfficeEntity()
        {
            SessionFactory.Init(@"Server=.\SQLEXPRESS;Database=DddInPractice;Trusted_Connection=true");

            HeadOfficeInstance.Init();
            var office = HeadOfficeInstance.Instance;
        }
    }
}