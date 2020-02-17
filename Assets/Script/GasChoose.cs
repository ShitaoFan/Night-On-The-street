using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasChoose : MonoBehaviour
{
    AudioSource wrongGas;
    public GameManager gameManager;
    
    Light gas;
    void Start()
    {
        wrongGas = GetComponent <AudioSource>();
        gas = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseEnter()
    {
        if(gameManager.carJustGetRight)
        gas.enabled=true; 
        
    }
 
    public void OnMouseExit()
    {
        if(gameManager.carJustGetRight)
        
        gas.enabled=false; 
    }
    void OnMouseDown() 
    {
        if(gameManager.carJustGetRight)
         wrongGas.Play();
    }
}
