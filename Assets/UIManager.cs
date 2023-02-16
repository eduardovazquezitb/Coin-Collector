using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private GameObject coinDisplayer;
    [SerializeField] private GameObject interactibleMessage;

    public void UpdateCoinDisplayer(int coins)
    {
        coinDisplayer.GetComponent<Text>().text = "x " + coins;
    }

    public void Update()
    {
        var player = GameManager.Instance.player;
        bool anyInteractible = false;
        GameManager.Instance.Interactibles.ForEach(interactible =>
        {
            IInteractible data = interactible.GetComponent<IInteractible>();
            float distance = (player.GetComponent<Transform>().position - interactible.GetComponent<Transform>().position).magnitude;
            if (distance < data.Radius())
            {
                anyInteractible = true;
                interactibleMessage.GetComponent<Text>().text = data.Message();
            }
        });
        if (!anyInteractible)
            interactibleMessage.GetComponent<Text>().text = "";
    }

}
