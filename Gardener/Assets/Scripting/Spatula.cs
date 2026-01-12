using UnityEngine;

public class Spatula : Tools
{
    public int holeNow = 0;
    public int holeAll = 21;
    protected override void Interact(Collider collider)
    {
        Mound Mound;
        if(collider.TryGetComponent(out Mound))
        {
            Mound.Dig();
            holeNow++;
        }
    }
}
