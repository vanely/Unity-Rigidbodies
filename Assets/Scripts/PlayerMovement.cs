using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public GameManage gameManager;
    public Transform ground;
    public PlayerCollision playerCollisionScript;
    bool canJump = true;
    public float accelerate = 1500f;
    public float steer = 30f;
    public float upwardMovement = 50f;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        // Debug.Log(player.position);
        if (rb.position.y < 0) {
            playerCollisionScript.isAlive = false;
            gameManager.EndGame();
        }
        // if (transform.position.y > (ground.position.y + 1.2)) {
        //     canJump = false;
        // } else {
        //     canJump = true;
        // }
    }

    // when making changes to physics Unity prefers that the method used for the frame updates be FixedUpdate() rather than Update()
    // collisions and physics changes become a lot smoother
    void FixedUpdate() {
        // frame rate varies for different computers. 
        // use Time.deltaTime to create an even ground for equal speed of added force despite frame rate.
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow)) {
            rb.AddForce(0, 0, accelerate * Time.deltaTime);
        }
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow)) {
            rb.AddForce(0, 0, -accelerate * Time.deltaTime);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddForce(-steer * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(steer * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (canJump && Input.GetKey("space")) {
            // instead of calculating y position, try checking that the box collider has made contact
            // Debug.Log("Ground Position: "+(ground.position.y + positionYMinusOne.y));
            Debug.Log("Player Jump: "+ transform.position.y);
            rb.AddForce(0, upwardMovement * Time.deltaTime, 0, ForceMode.Impulse);
        }
    }
}
