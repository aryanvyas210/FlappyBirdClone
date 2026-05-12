using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    public float movementSpeed;
    public float deadZone = -20;
    public BirdScript bird;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bird = FindFirstObjectByType<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
            if (bird != null && bird.birdIsAlive == true )
        {
            transform.position = transform.position + (Vector3.left * movementSpeed * Time.deltaTime);            
        }

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Destroyed");
            Destroy(gameObject);
        }
;
    }
}
