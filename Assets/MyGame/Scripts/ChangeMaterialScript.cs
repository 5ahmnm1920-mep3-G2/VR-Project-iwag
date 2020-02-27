using UnityEngine;

public class ChangeMaterialScript : MonoBehaviour
{
    public Material[] material;
    private Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "screwable")
        {
            rend.sharedMaterial = material[1];
        }
    }
}