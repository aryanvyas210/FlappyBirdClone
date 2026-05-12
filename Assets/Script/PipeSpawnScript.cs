using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset;
    public BirdScript bird;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bird = FindFirstObjectByType<BirdScript>();
        pipeSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (bird != null && bird.birdIsAlive == false)
        {
            return;
        }
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            pipeSpawn();
            timer = 0;
        }
    }

    void pipeSpawn()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
 
    }
}
