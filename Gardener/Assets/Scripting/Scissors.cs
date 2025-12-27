using UnityEngine;

public class Scissors : Tools//range of grass cutting
{
    protected override void Interact(Collider collider)
    {
        Grass Grass;
        if (collider.TryGetComponent(out Grass))
        {
            Grass.Cut();
        }
    }
}
