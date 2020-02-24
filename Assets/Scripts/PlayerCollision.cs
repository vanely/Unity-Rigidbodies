using UnityEngine;
using UnityEngine.SceneManagement;

// NOTE: when a game object is dragged into the project view, it becomes a prefab. When prefabs are edited, all instances of the given prefab across all scenes will update. Similar to a pointer
public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovementScript;
    public GameManage gameManager;
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Scene Count: "+SceneManager.sceneCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // this method is invoked when a collision is detected
    void OnCollisionEnter(Collision collisionInfo) {
        // Collision object has many classes and other objects that are able to be utilized for collision responses.
        // instead of creating a variable whose type is that of the component we want to manipulate.
        // we can call GetComponent<>(). 
        // the generic type of GetComponent<>() is the type of the component we want to manipulate.
        // the two are equal, we can still access all of the methods and properties of the given component.
        if (collisionInfo.collider.tag == "Obstacle") {
            Debug.Log(collisionInfo);    
            isAlive = false;
            // GetComponent<PlayerMovement>().enabled = false;
            playerMovementScript.enabled = false;

            // similarly we have FindObjectOfType which in this case will allow us to access the methods and properties of GameManager
            // using this is not as performant as creating a direct reference with a variable
            gameManager.EndGame();
        }
    }
}
