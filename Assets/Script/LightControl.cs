using UnityEngine;

public class NewLightControl : MonoBehaviour
{
    Material material;
    AudioSource greenlight;


    void Start ()
    {
        material = GetComponent<Material>();  
        greenlight = GetComponent<AudioSource>();
    }
 
    public void OnMouseEnter()
    {
        material.EnableKeyword("_EMISSION");
        greenlight.Play();
    }
 
    public void OnMouseExit()
    {
        material.DisableKeyword("_EMISSION");
    }
    // Start is called before the first frame update

}
