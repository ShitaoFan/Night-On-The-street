using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusComing : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject bus;
     AudioSource pavesound;

    Light man;
    Renderer man1;
    Vector3 manpos;
    float dist;
    // Start is called before the first frame update
    void Start()
    {
        // bus = GetComponent<GameObject>();
        man = GetComponent<Light>();
        man1 = GetComponent<Renderer>();
        pavesound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.lambController5click)
        {
         float dist = Vector3.Magnitude(manpos - Camera.main.WorldToScreenPoint(bus.transform.position));
         man.intensity= 2000/dist;
         Debug.Log(dist);
        }
    }
    void lightup()
    {
        gameManager.nowLightBusStation=true;
    }
    void pave()
    {
      pavesound.Play();
    }

    private void OnMouseEnter() 
    {
        
        man1.material.EnableKeyword("_EMISSION");
    }

    private void OnMouseExit() 
    {
        
        man1.material.DisableKeyword("_EMISSION");
    }
    private void OnMouseDown() 
    {
        if(gameManager.busarrive)
        {
        if(!gameManager.toolate)
        {
        man1.enabled=false; 
        man.enabled=false;
        }
        }
        
    }
}
