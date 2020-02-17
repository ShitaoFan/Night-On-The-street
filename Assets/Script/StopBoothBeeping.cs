using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBoothBeeping : MonoBehaviour
{
     Renderer _renderer;
    AudioSource PhoneRing;
    public AudioClip PickPhone;
    
    public GameManager gameManager;
 
    void Start ()
    {
        _renderer = GetComponent<Renderer>();  
        PhoneRing = GetComponent<AudioSource>();
      
    }
 
    public void OnMouseEnter()
    {
        _renderer.material.EnableKeyword("_EMISSION");
        
    }
 
    public void OnMouseExit()
    {
        if (!gameManager.phoneClicked)
        _renderer.material.DisableKeyword("_EMISSION");
    }
    
    void OnMouseDown() 
    {   
        PhoneRing.clip = PickPhone;
        PhoneRing.Play();
        _renderer.material.EnableKeyword("_EMISSION");
        gameManager.phoneClicked = true;
    }
}
