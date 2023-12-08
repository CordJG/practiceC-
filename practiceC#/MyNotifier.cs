
namespace HelloWrold
{
    delegate void EventHandler(string message);

    class MyNotifier
    {
    public event EventHandler(SomethingHappened);
    public void DoSomething(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappened(String.Format("{0} : ¦", number));
            }
        }
    }
}