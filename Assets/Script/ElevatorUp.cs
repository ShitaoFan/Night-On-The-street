using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorUp : MonoBehaviour
{
    AudioSource elevatorsound;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
     elevatorsound=GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Elevator()
    {
       elevatorsound.Play();
    }
    void nowistheend()
    {
      gameManager.nowistheend=true;
    }
}
