using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCokeMachine : MonoBehaviour
{
    Renderer _renderer;
    AudioSource cokeMachine;
    public Light lamp2;

    bool reset;

    public GameManager gameManager;

    bool clicked;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
        cokeMachine = GetComponent<AudioSource>();
    }


    void OnMouseEnter()
    {
        if (gameManager.phoneClicked)
            _renderer.material.EnableKeyword("_EMISSION");

    }

    void OnMouseExit()
    {
        if (!gameManager.cokeClicked)
            _renderer.material.DisableKeyword("_EMISSION");
    }

    void OnMouseDown()
    {
        if (gameManager.lambController1click)
        {
            cokeMachine.Play();
            _renderer.material.EnableKeyword("_EMISSION");
            gameManager.cokeClicked = true;
            lamp2.enabled=true;
        }

    }

}
