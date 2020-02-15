using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // this method is invoked when a collision is detected
    void OnCollisionEnter(Collision collisionInfo) {
        // Collision object has many classes and other objects that are able to be utilized for collision responses.
        Debug.Log(collisionInfo);
        if (collisionInfo.collider.tag == "Obstacle") {
            player.enabled = false;
        }
    }
}
