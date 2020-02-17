using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController8 : MonoBehaviour
{
    public GameManager gameManager;
    Light lamp8;
    public AudioSource Wire;
    public Renderer _renderer;
    

    public Animator TaxiLeave;
    
    AudioSource bell1;
    void Start()
    {
       lamp8 = GetComponent<Light>();
       bell1 = GetComponent <AudioSource>();

    }

    // Update is called once per frame
  
     void OnMouseEnter()
    {  
        if (gameManager.nowistheend)
        {
        if(!gameManager.lambController8click)
        lamp8.enabled=true;  
        }
    }
 
     void OnMouseExit()
    {
        if (gameManager.nowistheend)
        {
        if(!gameManager.lambController8click)
        lamp8.enabled=false;
        }
    }

       void OnMouseDown() 
    {
        if (gameManager.nowistheend)
        
        {
            lamp8.enabled=true; 
            gameManager.lambController8click=true;
            TaxiLeave.SetTrigger("TaxiLeave");
            _renderer.material.EnableKeyword("_EMISSION");
            Wire.Play();
            bell1.Play();
            
        }
    }

}

