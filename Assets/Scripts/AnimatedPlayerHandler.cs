using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class AnimatedPlayerHandler : MonoBehaviour
{
    public Transform animPlayer;

    void Update()
    {
        animPlayer.position = transform.position;
    }
}
