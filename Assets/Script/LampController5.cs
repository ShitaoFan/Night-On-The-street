using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController5 : MonoBehaviour
{
    public GameManager gameManager;
    Light lamp5;
    public Light man;
    public Light women;
    public Renderer WireRender;
    public AudioSource Wire;

    public Animator busMove;
    void Start()
    {
        lamp5 = GetComponent<Light>();

    }

    // Update is called once per frame
  
    public void OnMouseEnter()
    {  
        if(gameManager.nowLightBusStation)
        {
        if (!gameManager.lambController5click)
        lamp5.enabled=true;  
        }
    }
 
    public void OnMouseExit()
    {
        if(gameManager.nowLightBusStation)
        {
        if (!gameManager.lambController5click)
        lamp5.enabled=false;
        }
    }

      private void OnMouseDown() 
    {
        if (gameManager.nowLightBusStation)
        {
            lamp5.enabled=true; 
            busMove.SetTrigger("BusPark");
            gameManager.lambController5click=true;
            WireRender.material.EnableKeyword("_EMISSION");
            Wire.Play();
            
            

        }
    }
}
