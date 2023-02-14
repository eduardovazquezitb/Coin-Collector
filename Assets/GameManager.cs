using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private int _collectedCoins;
    public int CollectedCoins { get { return _collectedCoins; } }

    private void Start()
    {
        _collectedCoins = 0;
        EventManager.OnCoinHasBeenTaken += AddCoin;
    }

    private void OnDestroy()
    {
        EventManager.OnCoinHasBeenTaken -= AddCoin;
    }

    public void AddCoin()
    {
        _collectedCoins++;
        UIManager.Instance.UpdateCoinDisplayer(_collectedCoins);
    }
}
