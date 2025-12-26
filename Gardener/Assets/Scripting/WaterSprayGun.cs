using UnityEngine;

public class WaterSprayGun : Tools
{
    protected override void Interact(Collider collider)
    {
        Flower flower;
        if (collider.TryGetComponent(out flower))
        {
            Debug.Log("yesssss");
            flower.Recover();
        }
    }
}
