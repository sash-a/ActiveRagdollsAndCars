using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerActions))]
public class PlayerController : MonoBehaviour
{
    public PlayerActions actions;


    public Transform leftArm;
    public Transform rightArm;
    
    public Vector3 leftArmUpRotation;
    public Vector3 leftArmDownRotation;
    public Vector3 rightArmUpRotation;
    public Vector3 rightArmDownRotation;

    void Update()
    {
        handleInput();
    }

    private void LateUpdate()
    {
        // Hand movements
        
        // Up movement
        if (Input.GetKey(KeyCode.Space)) actions.rotateArm(leftArm, Quaternion.Euler(leftArmUpRotation));
        if (Input.GetKey(KeyCode.Space)) actions.rotateArm(rightArm, Quaternion.Euler(rightArmUpRotation));
        // Down movement
        if (Input.GetKeyUp(KeyCode.Space)) actions.rotateArm(leftArm, Quaternion.Euler(leftArmDownRotation));
        if (Input.GetKeyUp(KeyCode.Space)) actions.rotateArm(rightArm, Quaternion.Euler(rightArmDownRotation));
    }

    private void handleInput()
    {
        //  Walking
        var forward = Input.GetAxisRaw("Vertical");
        if (forward > 0) actions.walkForward();
        else if (forward < 0) actions.walkBack();

        var right = Input.GetAxisRaw("Horizontal");
        if (right > 0) actions.walkRight();
        else if (right < 0) actions.walkLeft();

      
    }
}
