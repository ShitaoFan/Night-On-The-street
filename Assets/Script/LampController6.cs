using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController6 : MonoBehaviour
{
    public GameManager gameManager;
    Light lamp6;
    public AudioSource Wire;
    public Renderer _renderer;
    

    public Animator carLeave;
    public AudioSource fillFuel;
    void Start()
    {
       lamp6 = GetComponent<Light>();

    }

    // Update is called once per frame
  
    public void OnMouseEnter()
    {  
        if (gameManager.lambController5click)
        lamp6.enabled=true;  
    }
 
    public void OnMouseExit()
    {
        if (!gameManager.lambController6click)
        lamp6.enabled=false;
    }

      private void OnMouseDown() 
    {
        if (gameManager.lambController5click)
        {
            lamp6.enabled=true; 
            gameManager.lambController6click=true;

            fillFuel.Stop();
            carLeave.SetTrigger("CarLeave");
            _renderer.material.EnableKeyword("_EMISSION");
            Wire.Play();
            
        }
    }
}
