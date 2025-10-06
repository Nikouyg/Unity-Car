using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed;
    private float horizontalInput;
    private float forwardInput;
    public float xRange = 15.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // we will move the vehicle forward based on vertical input

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // rotate the car based on horizontal input
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
          if (transform.position.x > xRange)
        {
            transform.position= new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
