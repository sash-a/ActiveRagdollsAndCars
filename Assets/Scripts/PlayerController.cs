using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerActions))]
public class PlayerController : MonoBehaviour
{
    public PlayerActions actions;
    void Start()
    {
           
    }

    void Update()
    {
        handleInput();
    }

    private void handleInput()
    {
        var forward = Input.GetAxisRaw("Vertical");
        if (forward > 0)
            actions.walkForward();
        else if (forward < 0)
            actions.walkBack();

        var right = Input.GetAxisRaw("Horizontal");
        
        Debug.Log(forward + " " + right);

        if (right > 0)
            actions.walkRight();
        else if (right < 0)
            actions.walkLeft();
    }
}
