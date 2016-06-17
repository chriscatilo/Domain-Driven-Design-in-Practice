using DddInPractice.Logic;
using NHibernate;
using Xunit;

namespace DddInPractice.Tests
{
    public class TemporaryDbTests
    {
        [Fact]
        public void Test()
        {
            SessionFactory.Init(@"Server=.\SQLEXPRESS;Database=DddInPractice;Trusted_Connection=true");

            using (ISession session = SessionFactory.OpenSession())
            {
                long id = 1;

                var snackMachine = session.Get<SnackMachine>(id);
            }
        }
    }
}
