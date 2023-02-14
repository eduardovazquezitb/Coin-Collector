

public class EventManager : Singleton<EventManager>
{

    public delegate void CoinHasBeenTaken();
    public static event CoinHasBeenTaken OnCoinHasBeenTaken;

    public static void CallOnCoinHasBeenTaken()
    {
        if (OnCoinHasBeenTaken != null)
            OnCoinHasBeenTaken();
    }

}
