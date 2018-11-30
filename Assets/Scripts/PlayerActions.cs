using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void walkForward()
    {
        Debug.Log("F");
    }

    public void walkBack()
    {
        Debug.Log("B");
    }

    public void walkRight()
    {
        Debug.Log("R");
    }

    public void walkLeft()
    {
        Debug.Log("L");
    }

    public void rotateArm(Transform arm, Quaternion targetRotation)
    {
        Debug.Log("Hands up");
//        arm.rotation = Quaternion.Slerp(arm.rotation, targetRotation, 0.2f);
        arm.localRotation = targetRotation;
    }
}
