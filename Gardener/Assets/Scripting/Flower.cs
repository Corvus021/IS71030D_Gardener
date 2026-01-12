using UnityEngine;

public class Flower : MonoBehaviour
{
    public GameObject colorFlower;
    public GameObject noColorFlower;
    public Animator Animator;
    public bool isWatered = false;
    
    public void Recover()
    {
        //recover flower
        noColorFlower.SetActive(false);
        colorFlower.SetActive(true);
        Animator.SetBool("Recover", true);
        isWatered = true;
    }
}