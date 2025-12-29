using UnityEngine;

//set item type (instead of tag)
public enum ItemType
{
    canBroken,
    canDestory
}
public class CanBreak : MonoBehaviour
{
    public GameObject Intact;
    public GameObject Broken;
    public ItemType itemType;

    public void Break()
    {
        //hidden model
        Intact.SetActive(false);
        //if it canBroken, show the broken model
        if(itemType == ItemType.canBroken && Broken != null)
        {
            Broken.SetActive(true);
        }
    }

}
