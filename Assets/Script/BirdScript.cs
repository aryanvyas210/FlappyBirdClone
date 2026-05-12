using System.Drawing;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public PointSystem Point;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Point = GameObject.FindGameObjectWithTag("Point").GetComponent<PointSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && birdIsAlive) 
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Point.gameOver();
        birdIsAlive = false;
    }
}
