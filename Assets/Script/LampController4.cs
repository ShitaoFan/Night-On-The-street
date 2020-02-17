using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController4 : MonoBehaviour
{
    public GameManager gameManager;
    Light lamp4;
    public Light man;
    public Light woman;
    Transform lightobject;
    public Renderer _renderer;
    AudioSource Wire;

    public AudioClip Fa;

    public Animator man1;

    float dist;

     void Update()
    {
        if(gameManager.nowCarIsRight)
        {
        if(!gameManager.lambController4click)
        {
         Vector3 mousePos = Input.mousePosition;
         float dist = 
         Vector3.Magnitude(mousePos - Camera.main.WorldToScreenPoint(lightobject.position));
         lamp4.intensity= 180/dist;
        
        }
        }
        
    }
    
    void Start()
    {
       lamp4 = GetComponent<Light>();
       lightobject = GetComponent <Transform>();
       Wire=GetComponent<AudioSource>();
    }
    public void OnMouseEnter()
    {
        if (gameManager.nowCarIsRight)
        {
        if(!gameManager.lambController4click)
        
        Wire.Play();
        }
        
    }
   
    public void OnMouseExit()
    {
        if (gameManager.nowCarIsRight)
        {
        if(!gameManager.lambController4click)
        Wire.Stop();
        }
    
    }
 
   
  
    

      private void OnMouseDown() 
    {
        if(gameManager.nowCarIsRight)
        {
            _renderer.material.EnableKeyword("_EMISSION");
            lamp4.intensity=5; 
            gameManager.lambController4click=true;
            man1.SetTrigger("ManMove");
            man.enabled=true;
            woman.enabled=true;
            Wire.clip=Fa;
            Wire.Play();
            

            
        }
    }

    
}
