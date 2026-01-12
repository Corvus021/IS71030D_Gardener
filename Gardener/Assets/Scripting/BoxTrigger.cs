using UnityEngine;

public class BoxTrigger : Box
{
    public bool canOpen;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canOpen = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canOpen = false;
        }
    }
    public void Update()
    {
        if (canOpen == true && Input.GetKeyDown(KeyCode.Q))
        {
            BoxControl();
        }
    }
}
