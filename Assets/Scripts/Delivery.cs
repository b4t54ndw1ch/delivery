using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);

    [SerializeField] float destroyDelay = 0.1f;

    SpriteRenderer spriteRenderer;

    bool hasTriangle = false;
    bool hasCircle = false;
    bool hasSquare = false;
    bool hasPackage = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

/*
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch! Collision happened.");
    }
*/

    void OnTriggerEnter2D(Collider2D other)
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
                hasTriangle = true;
                hasPackage = true;
                Debug.Log("TrianglePackage received.");
                spriteRenderer.color = hasPackageColor;
                Destroy(other.gameObject, destroyDelay);
                
            }

        } else if (other.tag == "CirclePackage")
        {
            if (hasPackage)
            {
                Debug.Log("You already have a Package.");
                return;
            }
            else
            {
                hasCircle = true;
                hasPackage = true;
                Debug.Log("CirclePackage received.");
                spriteRenderer.color = hasPackageColor;
                Destroy(other.gameObject, destroyDelay);
            }

        } else if (other.tag == "SquarePackage")
        {
            if (hasPackage)
            {
                Debug.Log("You already have a Package.");
                return;
            }
            else
            {
                hasSquare = true;
                hasPackage = true;
                Debug.Log("SquarePackage received.");
                spriteRenderer.color = hasPackageColor;
                Destroy(other.gameObject, destroyDelay);
            }

        } else if (other.tag == "TriangleCustomer")
        {
            if (hasTriangle)
            {
                hasTriangle = false;
                hasPackage = false;
                Debug.Log("TriangleCustomer delivered.");
                spriteRenderer.color = noPackageColor;
            }
            else
            {
                Debug.Log("TriangleCustomer detected.");
            }

        } else if (other.tag == "CircleCustomer")
        {
            if (hasCircle)
            {
                hasCircle = false;
                hasPackage = false;
                spriteRenderer.color = noPackageColor;
                Debug.Log("CircleCustomer delivered.");
            }
            else
            {
                Debug.Log("CircleCustomer detected.");
            }

        } else if (other.tag == "SquareCustomer")
        {
            if (hasSquare)
            {
                hasSquare = false;
                hasPackage = false;
                spriteRenderer.color = noPackageColor;
                Debug.Log("SquareCustomer delivered.");
            }
            else
            {
                Debug.Log("SquareCustomer detected.");
            }
        } 
    }
}





