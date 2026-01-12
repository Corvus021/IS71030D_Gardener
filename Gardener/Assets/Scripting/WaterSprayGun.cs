using UnityEngine;

public class WaterSprayGun : Tools
{
    public int flowerNow = 0;
    public int flowerAll = 35;
    protected override void Interact(Collider collider)
    {
        Flower Flower;
        if (collider.TryGetComponent(out Flower))
        {
            if(!Flower.isWatered)
            {
                Flower.Recover();
                flowerNow++;
            }
        }
    }
}
