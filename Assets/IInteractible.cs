using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractible
{
    public string Message();
    public float Radius();
    public void Interact();
}
