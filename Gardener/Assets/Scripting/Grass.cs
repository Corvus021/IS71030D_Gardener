using UnityEngine;

public class Grass : MonoBehaviour
{
    public GameObject longGrass;
    public GameObject shortGrass;
    public Transform Player;
    public bool isCutted = false;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);
    }
    public void Cut()//cut grass
    {
        longGrass.SetActive(false);
        shortGrass.SetActive(true);
        isCutted = true;
    }
}
