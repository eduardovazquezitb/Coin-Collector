using UnityEngine;


public class PhantomMessage : MonoBehaviour, IInteractible
{
    [SerializeField] private string message;
    [SerializeField] private float radius;
    public void Interact()
    {
        return;
    }

    public string Message()
    {
        return message;
    }

    public float Radius()
    {
        return radius;
    }
}
