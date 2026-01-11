using UnityEngine;

public class Well : MonoBehaviour
{
    public GameObject Ghost;
    public void Appeared()
    {
        Ghost.SetActive(true);
    }


}
