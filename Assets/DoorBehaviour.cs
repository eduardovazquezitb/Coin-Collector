using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour, IInteractible
{
    [SerializeField] private GameObject leftDoor;
    [SerializeField] private GameObject rightDoor;

    public void Interact()
    {
        leftDoor.GetComponent<Animator>().SetTrigger("Open");
        rightDoor.GetComponent<Animator>().SetTrigger("Open");
        Destroy(this.gameObject);
    }
}
