using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    public Canvas hint;
    public Canvas menu;
    // Start is called before the first frame update
   
    private void OnMouseDown() 
    {
        hint.enabled=true;
        menu.enabled=false;
    }
}
