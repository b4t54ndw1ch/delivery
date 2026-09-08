using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.1f;
    bool hasTriangle = false;
    bool hasCircle = false;
    bool hasSquare = false;
    bool hasPackage = false;



    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch! Collision happened.");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        PackagePickup();
        PackageDelivery();


        void PackagePickup()
        {
            if (other.tag == "TrianglePackage")
            {
                if (hasPackage)
                {
                    Debug.Log("You already have a Package.");
                    return;
                }
                else
                {
                    Destroy(other.gameObject, destroyDelay);
                    hasTriangle = true;
                    hasPackage = true;
                    Debug.Log("TrianglePackage received.");
                }
            }

            if (other.tag == "CirclePackage")
            {
                if (hasPackage)
                {
                    Debug.Log("You already have a Package.");
                    return;
                }
                else
                {
                    Destroy(other.gameObject, destroyDelay);
                    hasCircle = true;
                    hasPackage = true;
                    Debug.Log("CirclePackage received.");
                }
            }

            if (other.tag == "SquarePackage")
            {
                if (hasPackage)
                {
                    Debug.Log("You already have a Package.");
                    return;
                }
                else
                {
                    Destroy(other.gameObject, destroyDelay);
                    hasSquare = true;
                    hasPackage = true;
                    Debug.Log("SquarePackage received.");
                }
            }
        }

        void PackageDelivery()
        {
            if (other.tag == "TriangleCustomer" && hasTriangle)
            {
                hasTriangle = false;
                hasPackage = false;
                Debug.Log("TriangleCustomer delivered.");
            }
            else
            {
                Debug.Log("TriangleCustomer detected.");
            }

            if (other.tag == "CircleCustomer" && hasCircle)
            {
                hasCircle = false;
                hasPackage = false;
                Debug.Log("CircleCustomer delivered.");
            }
            else
            {
                Debug.Log("CircleCustomer detected.");
            }

            if (other.tag == "SquareCustomer" && hasSquare)
            {
                hasSquare = false;
                hasPackage = false;
                Debug.Log("SquareCustomer delivered.");
            }
            else
            {
                Debug.Log("SquareCustomer detected.");
            }
        }
    }
}




