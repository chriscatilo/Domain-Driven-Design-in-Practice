using DddInPractice.Logic;
using NHibernate;

namespace DddInPractice.UI.Common
{
    public class MainViewModel : ViewModel
    {
        public MainViewModel()
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                var snackMachine = session.Get<SnackMachine>(1L);
                var viewModel = new SnackMachineViewModel(snackMachine);
                _dialogService.ShowDialog(viewModel);
            }
        }
    }
}
