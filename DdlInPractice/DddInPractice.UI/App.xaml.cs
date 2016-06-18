using DddInPractice.Logic.Utils;

namespace DddInPractice.Logic.UI
{
    public partial class App
    {
        public App()
        {
            Initer.Init(@"Server=.\SQLEXPRESS;Database=DddInPractice;Trusted_Connection=true");
        }
    }
}
