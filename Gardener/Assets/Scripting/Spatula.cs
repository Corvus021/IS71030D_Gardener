using UnityEngine;

public class Spatula : Tools
{
    protected override void Interact(Collider collider)
    {
        Mound Mound;
        if(collider.TryGetComponent(out Mound))
        {
            Mound.Dig();
        }
    }
}
