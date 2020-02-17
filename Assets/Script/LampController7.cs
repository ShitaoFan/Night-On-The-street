using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController7 : MonoBehaviour
{
    public GameManager gameManager;
    Light lamp7;
    public AudioSource Wire;
    public Renderer _renderer;

    public Animator TaxiCome;
    void Start()
    {
       lamp7 = GetComponent<Light>();

    }

    // Update is called once per frame
  
    public void OnMouseEnter()
    {  
        if (gameManager.lambController6click)
        lamp7.enabled=true;  
    }
 
    public void OnMouseExit()
    {
        if (!gameManager.lambController7click)
        lamp7.enabled=false;
    }

      private void OnMouseDown() 
    {
        if (gameManager.lambController6click)
        {
            lamp7.enabled=true; 
            gameManager.lambController7click=true;
            TaxiCome.SetTrigger("TaxiCome");
            _renderer.material.EnableKeyword("_EMISSION");
            Wire.Play();
        }
    }

}
