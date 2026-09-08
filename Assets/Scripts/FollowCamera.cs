using UnityEngine;

// Delete this later


public class FollowCamera : MonoBehaviour
{
   [SerializeField] GameObject thingToFollow;
   // Camera position should be the same as the thingToFollow

    void LateUpdate()
    {
         transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
