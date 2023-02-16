using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private int _collectedCoins;
    public int CollectedCoins { get { return _collectedCoins; } }

    [SerializeField] public List<GameObject> Interactibles;
    [SerializeField] private GameObject floatingPlatform;

    public int totalCoins;

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
        if (_collectedCoins >= totalCoins)
            floatingPlatform.GetComponent<Animator>().SetTrigger("StartFloating");
    }
}
