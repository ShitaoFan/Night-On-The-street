using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LampController : MonoBehaviour
{
    public GameManager gameManager;
    Light lamp1;
    float dist;
    public Renderer _renderer;
     AudioSource Wire;

     public AudioClip Do;


    Transform lightobject;
    void Update()
    {
        if(!gameManager.lambController1click)
        {
         Vector3 mousePos = Input.mousePosition;
         float dist = 
         Vector3.Magnitude(mousePos - Camera.main.WorldToScreenPoint(lightobject.position));
         lamp1.intensity= 180/dist;
         Debug.Log(dist);
        }
        
    }
    
    void Start()
    {
       lamp1 = GetComponent<Light>();
       lightobject = GetComponent<Transform>();
       Wire = GetComponent<AudioSource>();

    }

    // Update is called once per frame
  
    public void OnMouseEnter()
    {
        if(!gameManager.lambController1click)
        Wire.Play();
        
    }
 
    public void OnMouseExit()
    {
        if(!gameManager.lambController1click)
        Wire.Stop();  
    }

      private void OnMouseDown() 
    {
        if (gameManager.phoneClicked)
        {
            if(!gameManager.lambController1click)
            _renderer.material.EnableKeyword("_EMISSION");
            lamp1.intensity=5; 
            gameManager.lambController1click=true;
            Wire.clip=Do;
            Wire.Play();
            
        }
    }
}
