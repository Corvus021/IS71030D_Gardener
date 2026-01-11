using UnityEngine;

public class Trumpet : Tools
{
    protected override void Interact(Collider collider)
    {
        Well Ghosts;
        if (collider.TryGetComponent(out Ghosts))
        {
            Ghosts.Appeared();
        }
    }
}
