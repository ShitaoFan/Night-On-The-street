using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : MonoBehaviour
{
    
     public Animator lift;
     
     AudioSource taxi;
     public AudioClip door;
     public AudioClip leavesound;
     public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        taxi = GetComponent<AudioSource>();
    }

    void taxiCome()
    {
        taxi.Play();
    }
    void doorclose()
    {
        taxi.clip=door;
        taxi.Play();
    }


    // Update is called once per frame
     void sleep()
    {
        lift.SetTrigger("Sleep");
        
    }
    void leave()
    {
        taxi.clip=leavesound;
        taxi.Play();
    }
    void manarrivehome()
    {
      gameManager.nowistheend=true;
    }

}
