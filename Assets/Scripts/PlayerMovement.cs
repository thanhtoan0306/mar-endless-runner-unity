using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5; // Speed of the player
    public Rigidbody rb; // Reference to the Rigidbody2D component

    float horizontalInput;

    private void FixedUpdate () 
    {
        Vector3 forwardMove = transform.forward * speed * Time.deltaTime; // Calculate forward movement
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.deltaTime; // Calculate horizontal movement
        rb.MovePosition(rb.position + forwardMove + horizontalMove); // Move the player forward

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
