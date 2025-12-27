using UnityEngine;

public class WaterSprayGun : Tools
{
    protected override void Interact(Collider collider)
    {
        Flower Flower;
        if (collider.TryGetComponent(out Flower))
        {
            Flower.Recover();
        }
    }
}
