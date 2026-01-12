using UnityEngine;

public class Mound : MonoBehaviour
{
    public int MaxdigNumber = 3;
    public int digNumber = 0;
    public float Scale = 0.8f;
    public AudioSource audioSource;
    public AudioClip bubbleClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Dig()
    {
        //dig soil
        digNumber++;
        if(digNumber>=MaxdigNumber)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.localScale *= Scale;
        }
        audioSource.clip = bubbleClip;
        audioSource.Play();
    }
}
