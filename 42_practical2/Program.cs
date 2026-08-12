using _42_practical2;

internal class Program
{
    private static void Main(string[] args)
    {
        Dialog dialog = new WindowsDialog();
        dialog.render();

        Dialog web = new WebDialog();
        web.render();
    }
}