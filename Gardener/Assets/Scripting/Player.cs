using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public Tools Tool;

    List<GameObject> toolsList = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Tool.useTool();
        }
    }
}
