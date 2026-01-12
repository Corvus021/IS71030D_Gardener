using UnityEngine;
using UnityEngine.UI;

public abstract class Box : MonoBehaviour
{
    public Text boxText;
    public Image boxImage;
    public bool isActive = false;
    public virtual void BoxControl()
    {
        if (isActive == false)
        {
            boxImage.gameObject.SetActive(true);
            isActive = true;
            boxText.text = "From a friend : Please take this trumpet to the well and play it there.";
        }
        else if (isActive != false)
        {
            boxImage.gameObject.SetActive(false);
            isActive = false;
        }
    }
}
