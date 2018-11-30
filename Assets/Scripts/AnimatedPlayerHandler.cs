using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedPlayerHandler : MonoBehaviour
{
    public GameObject animPlayer;

    void Update()
    {
        Debug.Log(transform.position);
        animPlayer.transform.SetPositionAndRotation(transform.position, transform.rotation);
    }
}
