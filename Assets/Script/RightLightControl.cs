using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLightControl : MonoBehaviour
{
    Renderer _renderer;
    AudioSource greenLight;
    Light lamp1;
    float dist;

    Transform lightobject;
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        float DistanceFromMyObjectToMouseInPixels = 
        Vector3.Magnitude(Camera.main.WorldToScreenPoint(mousePos) - Input.mousePosition);
        lamp1.intensity= 500/dist;
        
    }

 
    void Start ()
    {
        _renderer = GetComponent<Renderer>();  
        greenLight = GetComponent<AudioSource>();
    }
 
    public void OnMouseEnter()
    {
        _renderer.material.EnableKeyword("_EMISSION");
        greenLight.Play();
    }
 
    public void OnMouseExit()
    {
        _renderer.material.DisableKeyword("_EMISSION");
    }
}
   
