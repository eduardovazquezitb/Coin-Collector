using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour, IInteractible
{
    [SerializeField] private GameObject leftDoor;
    [SerializeField] private GameObject rightDoor;
    [SerializeField] private string message;
    [SerializeField] private float radius;

    public void Interact()
    {
        leftDoor.GetComponent<Animator>().SetTrigger("Open");
        rightDoor.GetComponent<Animator>().SetTrigger("Open");
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        message = "";
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
