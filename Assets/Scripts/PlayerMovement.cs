using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5; // Speed of the player
    public Rigidbody rb; // Reference to the Rigidbody2D component

    private void FixedUpdate () 
    {
        Vector3 forwardMove = transform.forward * speed * Time.deltaTime; // Calculate forward movement
        rb.MovePosition(rb.position + forwardMove); // Move the player forward

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
