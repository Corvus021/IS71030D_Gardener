using UnityEngine;

public class Hammer : Tools
{
    protected override void Interact(Collider collider)
    {
        CanBreak canBreak;
        if (collider.TryGetComponent(out canBreak))
        {
            canBreak.Break();
        }
    }
}
