using UnityEngine;

public class PickupTool : MonoBehaviour
{
    public Tools Tool;

    //input player component
    public void PickUp(Player Player)
    {
        Player.TakeTool(Tool);
        gameObject.SetActive(false);
    }
}
