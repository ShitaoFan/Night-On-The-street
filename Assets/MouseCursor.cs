using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    
    private SpriteRenderer rend;
    Animator scale;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible=false;
        rend = GetComponent<SpriteRenderer>();
        scale = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 cursorPos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position=cursorPos;
         if (Input.GetMouseButtonDown(0))
         scale.SetTrigger("Scale");

         else if (Input.GetMouseButtonUp(0))
         
            scale.ResetTrigger("Scale");
    
    }
        
    
}
