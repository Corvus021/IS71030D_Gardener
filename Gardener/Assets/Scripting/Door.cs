using UnityEngine;

public abstract class Door : MonoBehaviour
{
    public bool isOpen = false;
    public Animator Animator;
    
    public virtual void OpenDoor()
    {
        if(!isOpen)
        {
            isOpen = true;
        }
        Animator.SetBool("isOpen", true);

    }
    public virtual void CloseDoor()
    {
        if (isOpen)
        {
            isOpen = false;
        }
        Animator.SetBool("isOpen", false);
    }
}
