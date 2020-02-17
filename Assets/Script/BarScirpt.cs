using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarScirpt : MonoBehaviour
{
    public Animator carMove;
    public Animator barLift;
    public GameManager gameManager;
    AudioSource liftsound;
    
    public GameObject Light;
    Renderer _gasLight;
    // Start is called before the first frame update
    void Start()
    {
        _gasLight = Light.GetComponent<Renderer>();
        liftsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void barliftsound()
    {
        liftsound.Play();
        
    }
     void OnMouseEnter()
    {
        if(gameManager.lambController3click)
       {
        barLift.SetTrigger("BarShake");
       }
        
    }
    void OnMouseExit() 
    {
       if(gameManager.lambController3click)
       {
        barLift.ResetTrigger("BarShake");
       } 
    }
  
    
     private void OnMouseDown() 
     
     {
       if(gameManager.lambController3click)
       {
       carMove.SetTrigger("CarPark");
       barLift.SetTrigger("BarLift");
       gameManager.nowGoGas=true;
       }
     }





   
}
