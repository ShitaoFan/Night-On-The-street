using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireSoundController : MonoBehaviour
{
     Renderer _renderer;
    AudioSource Wire;
    Animator shake;
    

 
    void Start ()
    {
        _renderer = GetComponent<Renderer>();  
        Wire = GetComponent<AudioSource>();
        shake = GetComponent<Animator>();
      
    }
    private void OnMouseExit() 
    {
        shake.ResetTrigger("Shake");
    }
 
    public void OnMouseEnter()
    {
        if(_renderer.material.IsKeywordEnabled("_EMISSION"))
        Wire.Play();
        shake.SetTrigger("Shake");
        
    }
 
   

    
}
