using UnityEngine;

public class Scissors : MonoBehaviour//range of grass cutting
{
    public float CutRange = 2f;
    public float RayDistance = 1f;
    public LayerMask Mask;
    private Collider [] colliders = new Collider[8];

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //ray from main camera to mouse click position
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            //information on what the rays hit
            RaycastHit hit;

            //Along the ray "mouseRay", the distance of the firing "RayDistance", the information of all the objects hit is stored in the "hit"
            if (Physics.Raycast(mouseRay, out hit, RayDistance))
            {
                //return the number of hit items (detecting colliders within the sphere(center of sphere, sphere range, hit colliders, which layer)) 
                int hitCount = Physics.OverlapSphereNonAlloc(hit.point, CutRange, colliders, Mask);
                for (int i = 0; i < hitCount; i++)
                {
                    Grass grass;
                    if(colliders[i].TryGetComponent(out grass))
                    {
                        grass.Cut();
                    }
                }
            }
        }
     
    }

    
}
