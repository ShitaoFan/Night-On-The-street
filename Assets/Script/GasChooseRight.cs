using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasChooseRight : MonoBehaviour
{
    AudioSource rightGas;
    public AudioClip fuel;
    public GameManager gameManager;
    public Animator car;
    public Light lamp4;
    Light gaslight;
    // Start is called before the first frame update
    void Start()
    {
        rightGas = GetComponent <AudioSource>();
        gaslight = GetComponent<Light>();
        
    }
    public void OnMouseEnter()
    {  if(gameManager.carJustGetRight)
    {
        if(!gameManager.nowCarIsRight)
    {
        gaslight.enabled=true; 
    }
    }
        
    }
 
    public void OnMouseExit()
    {   if(gameManager.carJustGetRight)
    {
        if(!gameManager.nowCarIsRight)
        {
         gaslight.enabled=false; 
        }
    }
    }


    // Update is called once per frame

    void OnMouseDown() 
    {
        if(gameManager.nowGoGas)
        {
         rightGas.Play();
         gaslight.enabled = true;
        }

        if(gameManager.carJustGetRight)
        {
         rightGas.Play();
         gaslight.enabled = true;
         car.SetTrigger("FindGas");
        }

        if(gameManager.nowCarIsRight)
        {
         gaslight.enabled = true;
         lamp4.enabled=true;
        }

    }
    void Update()

    {
        
        if(gameManager.nowCarIsRight) 
        {
            if(!gameManager.lambController6click)
            {
            
            if (Input.GetMouseButtonDown(0))
        {
           gaslight.enabled = true;
           rightGas.clip=fuel;
           rightGas.Play();
           lamp4.enabled=true;
           gaslight.range -= Time.deltaTime;
           
        }
         else if (Input.GetMouseButtonUp(0))
        { 
            gaslight.enabled = false;
            rightGas.Pause();
        }
            }
        }
        
        
        
    }
     
    
}
