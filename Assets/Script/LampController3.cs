using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController3 : MonoBehaviour
{
    public GameManager gameManager;
    Light lamp3;
    Vector3 light3;
    
    public Light gastation;
    public GameObject car;
    public Renderer _renderer;
    AudioSource Wire;
    public AudioClip Mi;
    void Start()
    {
       lamp3 = GetComponent<Light>();
       Wire = GetComponent<AudioSource>();

    }
    void Update()
    {   if (!gameManager.lambController3click)
        {
         float dist = Vector3.Magnitude(light3 - Camera.main.WorldToScreenPoint(car.transform.position));
         lamp3.intensity= 3000/(dist-300);
         Debug.Log(dist);
        }
    }

     public void OnMouseEnter()
    {
        if (gameManager.cararrive)
        {
        if(!gameManager.lambController3click)
        
        Wire.Play();
        }
        
    }
  
    public void OnMouseExit()
    {
        if (gameManager.cararrive)
        {
        if(!gameManager.lambController3click)
        Wire.Stop();
        }
    
    }

      private void OnMouseDown() 
    {
        if (gameManager.lambController2click)
        {
        if(gameManager.cararrive)
        {
            lamp3.enabled=true; 
            lamp3.intensity=5; 
            gastation.enabled=true;
            gameManager.lambController3click=true;
            _renderer.material.EnableKeyword("_EMISSION");
            Wire.clip=Mi;
            Wire.Play();
        }
        }
    }
}
