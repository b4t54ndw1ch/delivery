using UnityEngine;

public class Collision : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D other)
   {
      Debug.Log("Ouch! Collision happened.");
   }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Wha? Trigger happened.");
    }

}
