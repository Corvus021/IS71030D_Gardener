using UnityEngine;

public class Ghosts : MonoBehaviour
{
    public GameObject Ghost;
    public void Appeared()
    {
        //ghosts appeared
        Ghost.SetActive(true);
    }


}
