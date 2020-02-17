using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetOnBus : MonoBehaviour

{
    Renderer man;
    // Start is called before the first frame update
    void Start()
    {
        man = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnMouseDown() 
    {
        man.enabled=false; 
    }
}
