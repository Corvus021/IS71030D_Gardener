using UnityEngine;

public class Hammer : Tools
{
    public int stoneNow = 0;
    public int stoneAll = 5;
    protected override void Interact(Collider collider)
    {
        CanBreak canBreak;
        if (collider.TryGetComponent(out canBreak))
        {
            if(!canBreak.isBroken)
            {
                canBreak.Break();
                stoneNow++;
            }
        }
    }
}
