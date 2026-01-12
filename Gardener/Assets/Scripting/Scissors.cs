using UnityEngine;

public class Scissors : Tools//range of grass cutting
{
    public int grassNow = 0;
    public int grassAll = 700;
    protected override void Interact(Collider collider)
    {
        Grass Grass;
        if (collider.TryGetComponent(out Grass))
        {
            if(!Grass.isCutted)
            {
                Grass.Cut();
                grassNow++;
            }
        }
    }
}
