using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private GameObject coinDisplayer;

    public void UpdateCoinDisplayer(int coins)
    {
        coinDisplayer.GetComponent<Text>().text = "x " + coins;
    }
}
