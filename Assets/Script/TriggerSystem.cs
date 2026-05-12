using UnityEngine;

public class TriggerSystem : MonoBehaviour
{
    public PointSystem Point;
    public bool hasScored = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Point = GameObject.FindGameObjectWithTag("Point").GetComponent<PointSystem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && !hasScored)
        {
            Point.addScore(1);
            hasScored = true;
        }
    }
}