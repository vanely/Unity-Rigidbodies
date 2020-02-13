using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public float movement = 500f;
    public float upwardMovement = 1500f;
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        // Debug.Log(player.position);
        
    }

    // when making changes to physics Unity prefers that the method used for the frame updates be FixedUpdate() rather than Update()
    // collisions and physics changes become a lot smoother.
    void FixedUpdate() {
        // frame rate varies for different computers. 
        // use Time.deltaTime to create an even ground for equal speed of added force despite frame rate.
        if (Input.GetKey("w")) {
            rb.AddForce(0, 0, movement * Time.deltaTime);
        }
        if (Input.GetKey("s")) {
            rb.AddForce(0, 0, -movement * Time.deltaTime);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-movement * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d")) {
            rb.AddForce(movement * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("space")) {
            rb.AddForce(0, upwardMovement * Time.deltaTime, 0);
        }
    }

    // this method is executed whenever a collision occurs.
    void OnCollisionEnter(Collision collisionInfo) {
        // collision is an instance of Collision, and there are other objects, methods and properties to access inside
        Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.name == "Obstacle") {
            Debug.Log("Oh Shit!");
        }
    }

    // public void move() {
    //     if (w == "pressed") {
    //         rb.AddForce(0, 0, 300);
    //     }
    // }
}
