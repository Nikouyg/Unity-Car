using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float speed = 4f;   // How fast it moves
    public float distance = 3f; // How far it moves up and down

    private Vector3 startPos;

    void Start()
    {
        // Remember where the obstacle starts
        startPos = transform.position;
    }

    void Update()
    {
        // PingPong goes back and forth between 0 and 'distance'
        float newY = startPos.y + Mathf.PingPong(Time.time * speed, distance);
        
        // Apply the new position
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}
