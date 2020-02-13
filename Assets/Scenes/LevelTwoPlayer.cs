using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTwoPlayer : MonoBehaviour
{
    public Rigidbody rbz;
    // Start is called before the first frame update
    void Start()
    {
        rbz.AddForce(0, 300, 600 * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        rbz.AddForce(0, 0, 300 * Time.deltaTime);
    }
}
