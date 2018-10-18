using UnityEngine;
using System.Collections;
 
public class HingeJointTarget : MonoBehaviour {
 
    public HingeJoint hj;
    public Transform target;
    [Tooltip("Only use one of these values at a time. Toggle invert if the rotation is backwards.")]
    public bool x, y, z, invert;
     
    void Update ()
    {
        if (hj != null)
        {
            JointSpring js;
            js = hj.spring;
            
            if (x)
            {
                js.targetPosition = target.transform.localEulerAngles.x;
                if (js.targetPosition > 180)
                    js.targetPosition = js.targetPosition - 360;
                if (invert)
                    js.targetPosition = js.targetPosition * -1;
 
                js.targetPosition = Mathf.Clamp(js.targetPosition, hj.limits.min + 5, hj.limits.max - 5);
 
                hj.spring = js;
            }
            else if (y)
            {
                js.targetPosition = target.transform.localEulerAngles.y;
                if (js.targetPosition > 180)
                    js.targetPosition = js.targetPosition - 360;
                if (invert)
                    js.targetPosition = js.targetPosition * -1;
 
                js.targetPosition = Mathf.Clamp(js.targetPosition, hj.limits.min + 5, hj.limits.max - 5);
 
                hj.spring = js;
            }
            else if (z)
            {
                js.targetPosition = target.transform.localEulerAngles.z;
                if (js.targetPosition > 180)
                    js.targetPosition = js.targetPosition - 360;
                if (invert)
                    js.targetPosition = js.targetPosition * -1;
 
                js.targetPosition = Mathf.Clamp(js.targetPosition, hj.limits.min + 5, hj.limits.max - 5);
 
                hj.spring = js;
            }
        }
    }
}