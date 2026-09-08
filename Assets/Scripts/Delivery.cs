using UnityEngine;

public class Delivery : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D other)
   {
      Debug.Log("Ouch! Collision happened.");
   }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "TrianglePackage")
        {
            Debug.Log("TrianglePackage received.");
        }else if (other.tag == "CirclePackage")
        {
            Debug.Log("CirclePackage received.");
        }
        else if (other.tag == "SquarePackage")
        {
            Debug.Log("SquarePackage received.");
        } 
        
        if (other.tag == "TriangleCustomer")
        {
            Debug.Log("TriangleCustomer delivered.");
        }else if (other.tag == "CircleCustomer")
        {
            Debug.Log("CircleCustomer delivered.");
        }
        else if (other.tag == "SquareCustomer")
        {
            Debug.Log("SquareCustomer delivered.");
        }

    }

}
