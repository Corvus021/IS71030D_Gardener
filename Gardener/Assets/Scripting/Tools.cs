using UnityEngine;

public abstract class Tools : MonoBehaviour
{
    public float Range = 2f;
    public float rayDistance = 1f;
    public LayerMask Mask;
    public LayerMask toolsMask;
    private Collider[] colliders = new Collider[8];

    private void Start()
    {
        toolsMask = ~LayerMask.GetMask("Tools");
    }
    public virtual void useTool()
    {
        //ray from main camera to mouse click position
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //information on what the rays hit
        RaycastHit hit;

        if (Physics.Raycast(mouseRay, out hit, rayDistance, toolsMask))
        {
            Debug.Log(hit.collider.name);
            //return the number of hit items (detecting colliders within the sphere(center of sphere, sphere range, hit colliders, which layer)) 
            int hitCount = Physics.OverlapSphereNonAlloc(hit.point, Range, colliders, Mask);
            for (int i = 0; i < hitCount; i++)
            {
                Interact(colliders[i]);
            }
        }
    }

    //"protected" means it can be overridden by the parent class and their children class (other class can't)
    protected abstract void Interact(Collider collider);
}
