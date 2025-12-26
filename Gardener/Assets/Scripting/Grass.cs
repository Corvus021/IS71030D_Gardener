using UnityEngine;

public class Grass : MonoBehaviour
{
    public GameObject longGrass;
    public GameObject shortGrass;
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
    }
    public void Cut()//cut grass
    {
        longGrass.SetActive(false);
        shortGrass.SetActive(true);
    }
}
