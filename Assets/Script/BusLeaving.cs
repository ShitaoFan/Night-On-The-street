using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusLeaving : MonoBehaviour
{
    Animator bus;
    public GameManager gameManager;
    public AudioClip busleavesound;
    AudioSource buscoming;
    // Start is called before the first frame update
    void Start()
    {
        bus = GetComponent<Animator>();
        buscoming = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void busleave()
    {
        gameManager.busleave=true;
        buscoming.clip=busleavesound;
        buscoming.Play();
    }
    void busarrive()
    {
      gameManager.busarrive=true;
      buscoming.Play();
    }
    void toolate()
    {
        gameManager.toolate=true;
    }
    private void OnMouseDown() 
    {
        bus.SetTrigger("BusLeave");
    }
}
