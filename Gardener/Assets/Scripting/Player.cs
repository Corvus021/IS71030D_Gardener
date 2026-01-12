using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public float rayDistance = 1f;
    public LayerMask Mask;
    public Tools currentTool;
    public Animator Animator;
    private int curtoolNumber = 0;

    public List<Tools> toolsList = new List<Tools>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SwitchTool();
        if (Input.GetKeyDown(KeyCode.E))
        {
            FindTools();
        }
        if (Input.GetMouseButtonDown(0)&& currentTool != null)
        {
            currentTool.useTool();
        }
        //if player move
        bool isMove=Mathf.Abs(Input.GetAxis("Horizontal"))>0.1f|| Mathf.Abs(Input.GetAxis("Vertical"))>0.1f;
        if(isMove)
        {
            Animator.SetBool("isMove", true);
        }
        else
        {
            Animator.SetBool("isMove", false);
        }
    }
    void FindTools()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(mouseRay, out hit, rayDistance, Mask))
        {
            Debug.Log(hit.collider.name);
            PickupTool pickedTool = hit.collider.GetComponent<PickupTool>();
            if (pickedTool != null)
            {
                //this player pickup tool
                pickedTool.PickUp(this);
            }
        }
    }
    public void TakeTool(Tools Tool)
    {
        //Contains:is this tool in the list?
        //no this tool, add it to toolsList
        if(!toolsList.Contains(Tool))
        {
            toolsList.Add(Tool);
        }
        //now which tool we take
        SelectionTool(Tool);
    }
    public void SelectionTool(Tools Tool)
    {
        for (int i = 0; i < toolsList.Count; i++)
        {
            toolsList[i].gameObject.SetActive(toolsList[i] == Tool);
            if (toolsList[i] == Tool)
            {
                curtoolNumber = i;
            }
        }
        currentTool = Tool;
        Debug.Log("Tool:" + Tool.name);
    }
    void SwitchTool()
    {
        //Count:how many things in this list
        if(toolsList.Count == 0)
        {
            return;
        }
        float rolling = Input.GetAxis("Mouse ScrollWheel");

        if(rolling > 0f)
        {
            curtoolNumber++;
        }
        else if(rolling < 0f)
        {
            curtoolNumber--;
        }
        //"%"getting the remainder after dividing two numbers(a%b=a-(a/b)*b)
        curtoolNumber = (curtoolNumber + toolsList.Count) % toolsList.Count;
        for (int i = 0; i < toolsList.Count; i++)
        {
            //SetActive(true) when i=curtoolNumber(which one you take now), otherwise SetActive(flase)
            toolsList[i].gameObject.SetActive(i == curtoolNumber);
        }
        currentTool = toolsList[curtoolNumber];
    }
}
