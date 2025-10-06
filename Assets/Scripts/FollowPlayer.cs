using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -12);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {  // offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset; 
    }
}
