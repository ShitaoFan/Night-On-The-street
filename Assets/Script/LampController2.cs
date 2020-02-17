using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController2 : MonoBehaviour
{
    public GameManager gameManager;
    Light lamp2;
    float dist;
    public Light lamp3;
    public Renderer _renderer;
    AudioSource Wire;
    public AudioClip Re;
    public Animator car;

    Transform lightobject;
    void Update()
    {
        if(gameManager.cokeClicked)
        {
        if(!gameManager.lambController2click)
        {
         Vector3 mousePos = Input.mousePosition;
         float dist = 
         Vector3.Magnitude(mousePos - Camera.main.WorldToScreenPoint(lightobject.position));
         lamp2.intensity= 180/dist;
        }
        }
        
    }
    
    void Start()
    {
       lamp2 = GetComponent<Light>();
       lightobject = GetComponent<Transform>();
       Wire=GetComponent<AudioSource>();

    }


    // Update is called once per frame
     public void OnMouseEnter()
    {
        if (gameManager.cokeClicked)
        {
        if(!gameManager.lambController2click)
        
        Wire.Play();
        }
        
    }
 
    public void OnMouseExit()
    {
        if (gameManager.cokeClicked)
        {
        if(!gameManager.lambController2click)
        Wire.Stop();
        }
        
    }
  
    

      private void OnMouseDown() 
    {
        if (gameManager.cokeClicked)
        {
            if(!gameManager.lambController2click)
            _renderer.material.EnableKeyword("_EMISSION");
            lamp2.intensity=5; 
            gameManager.lambController2click=true;
            car.SetTrigger("MoveCar");
            lamp3.enabled=true; 
            Wire.clip=Re;
            Wire.Play();
        }
    }
}
