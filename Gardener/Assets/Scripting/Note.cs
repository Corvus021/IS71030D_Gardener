using UnityEngine;
using UnityEngine.UI;

public abstract class Note : MonoBehaviour
{
    public bool isEnd = false;
    public float flowerPerce;
    public float grassPerce;
    public float holePerce;
    public float stonePerce;
    public Text flowerText;
    public Text grassText;
    public Text holeText;
    public Text stoneText;
    public Image noteImage;
    public bool isActive = false;
    public WaterSprayGun Flower;
    public Scissors Grass;
    public Spatula Hole;
    public Hammer Stone;

    public virtual void NoteControl()
    {
        if (isActive == false)
        {
            noteImage.gameObject.SetActive(true);
            isActive = true;
            flowerPerce = ((float)Flower.flowerNow / Flower.flowerAll) * 100f;
            grassPerce = ((float)Grass.grassNow / Grass.grassAll) * 100f;
            holePerce = ((float)Hole.holeNow / Hole.holeAll) * 100f;
            stonePerce = ((float)Stone.stoneNow / Stone.stoneAll) * 100f;
            flowerText.text = $"Watered Flower : {(int)flowerPerce}%";
            if(grassPerce>100)
            {
                grassPerce = 100;
            }
            grassText.text = $"Cutted Grass : {(int)grassPerce}%";
            holeText.text = $"Filled Hole : {(int)holePerce}%";
            stoneText.text = $"Broken Stone : {(int)stonePerce}%";
        }
        else if (isActive != false)
        {
            noteImage.gameObject.SetActive(false);
            isActive = false;
        }
        if(flowerPerce == 100 && grassPerce == 100 && holePerce == 100 && stonePerce == 100)
        {
            isEnd = true;
        }
    }
}
