using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 200f;
    [SerializeField] private float moveSpeed = 30f;
    [SerializeField] private float slowSpeed = 15f;
    [SerializeField] private float boostSpeed = 50f;


    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
            Debug.Log("Hit a Boost!");
        }
        else if (other.tag == "Bump")
        {
            moveSpeed = slowSpeed;
            Debug.Log("Hit a Bump!");
        }
    }
}
