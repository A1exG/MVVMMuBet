namespace MySportBets.UserInterface.Services
{
    public interface IView<TDataContext>
    {
        TDataContext DataContext { get; set; }

        bool? ShowDialog();

        void Close();
    }
}
