using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Ghost : MonoBehaviour
{
    public Animator Animator;
    public Transform Player;
    public Transform[] movePoint;
    public GameObject theGhost;
    public Text ghostText;
    public float textWait;
    public int taskStep = 0;
    public bool canTalk = true;
    public Note Note;
   
    void Update()
    {
        transform.LookAt(Player);
    }
    public void OnTriggerEnter(Collider other)
    {
        if(!canTalk)
        {
            return;
        }
        if(other.CompareTag("Player"))
        {
            //ghost event
            StartCoroutine(GhostWork());
        }
    }
    IEnumerator GhostWork()
    {
        canTalk = false;
        //ghost appear
        theGhost.SetActive(true);
        ghostText.gameObject.SetActive(true);
        string ghostSay = "";
        switch(taskStep)
        {
            case 0:
                ghostSay = "Hey, watch out! Don't get so close to the well!";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                ghostSay = "Are you ok? You look as pale as a ghost! Is it a heart problem? Low blood? Or is it¡ª";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                ghostSay = "...I know where the problem is.";
                ghostText.text = ghostSay;
                break;
            case 1:
                ghostSay = "I'm...so sorry for that.";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                ghostSay = "You¡¯re the new gardener, right? I haven¡¯t seen anyone alive in ages, so I¡¯m a little excited.";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                ghostSay = "You got something to say?";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                ghostSay = "No? Alright, I guess I¡¯ll leave you alone.";
                ghostText.text = ghostSay;
                break;
            case 2:
                ghostSay = "Ah, the poor small gnawing animals have lost their homes.";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                ghostSay = "But I don¡¯t feel sorry for them at all¡ªlook at this grass that¡¯s been eaten completely bare!";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                ghostSay = "...";
                ghostText.text = ghostSay;
                break;
            case 3:
                Animator.Play("FlyHammer");
                ghostSay = "Oh my god! Are you okay? I just wanted to give you that thing, not let it broken your head.";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                ghostSay = "I¡¯m a bit clumsy...";
                ghostText.text = ghostSay;
                break;
            case 4:
                ghostSay = "I hope you like this fountain! It¡¯s really a miracle that it still works now... My family used to love sitting here reading.";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                ghostSay = "Hey, gardener,say something, please?";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                ghostSay = "Anything is fine... Just don¡¯t let me talk to myself...";
                ghostText.text = ghostSay;
                break;
            case 5:
                ghostSay = "I feel so lonely. I feel so cold. I...";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                ghostSay = "I want someone to talk to.";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                ghostSay = "But maybe having a listener is not bad too.";
                ghostText.text = ghostSay;
                break;
            case 6:
                //wait for isEnd
                while(!Note.isEnd)
                {
                    yield return null;
                }
                ghostSay = "You¡¯ve finished your work! This garden finally looks like a real one!";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                ghostSay = "I think I should say thank you. Even though you¡¯re quiet, but... it¡¯s nice to have someone around. At least you didn¡¯t run away like the others.";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                ghostSay = "...Maybe you¡¯re a pretty cool person? Goodbye, gardener¡ª¡ªI¡¯ll miss you.";
                ghostText.text = ghostSay;
                yield return new WaitForSeconds(textWait);
                //End Game
                SceneManager.LoadScene("MainMenu");
                break;
        }
        //wait for talk done
        yield return new WaitForSeconds(textWait);
        ghostText.gameObject.SetActive(false);
        if (taskStep<6)
        {
            theGhost.transform.position = movePoint[taskStep].position;
        }
        taskStep++;
        canTalk = true;
        yield return null;
    }
}
