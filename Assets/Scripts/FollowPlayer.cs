using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // can refer to transform with or without creating instance 
    // public Transform cam;
    
    // the Vector3 class gives us three fields (X, Y, Z)
    // we can add vectors (transform.position = player.position + offset) to add some change to where the camera starts.
    public Vector3 offset;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // drag player object in Hierarchy into the player field on the script attached to main camera.
        // when refering to transform in lower case, without first creating an instance, it applies to the current object that the script is in
        transform.position = player.position + offset;
        // cam.position = player.position;
    }
}
