using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScritpt : MonoBehaviour
{

    public Animator bar;
    public GameManager gameManager;

    public AudioClip carParking;

    AudioSource carcoming;
     


     public AudioClip carLeaving;
     
     


    // Start is called before the first frame update
    void Start()
    {
        carcoming = GetComponent<AudioSource>();
        
    }
    

    // void Update()
    // {   
    //     if (Input.GetAxis("Mouse ScrollWheel") > 0) 
    //     transform.position += Vector3.forward * 30*Time.deltaTime;
    
    //     if (Input.GetAxis("Mouse ScrollWheel") < 0) 
    //     transform.position -= Vector3.back * 30*Time.deltaTime;
    
    // }

    
     void BarLift()
    {
       bar.SetTrigger("BarLift");
       
    }

    
    void carcome()
    {
        
        carcoming.Play();

    }
    void parksound()
    {
        carcoming.clip=carParking;
        carcoming.Play();
    }

    
     void carLeave()
    {
        carcoming.clip=carLeaving;
        carcoming.Play();

    }
    void cararrive()
    {
        gameManager.cararrive=true;
        
    }
    void carsSeemGetRight()
    {
        gameManager.carJustGetRight=true;
    }
    void carisright()
    {
        gameManager.nowCarIsRight=true;
    }

    

    
    


    
}
