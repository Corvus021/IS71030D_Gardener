using UnityEngine;

public class Mound : MonoBehaviour
{
    public int MaxdigNumber = 3;
    public int digNumber = 0;
    public float Scale = 0.8f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Dig()
    {
        digNumber++;
        if(digNumber>=MaxdigNumber)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.localScale *= Scale;
        }
        //dig soil
    }
}
