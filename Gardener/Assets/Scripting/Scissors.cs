using UnityEngine;

public class Scissors : Tools//range of grass cutting
{
    protected override void Interact(Collider collider)
    {
        Grass grass;
        if (collider.TryGetComponent(out grass))
        {
            grass.Cut();
        }
    }
}
