
using UnityEngine;
// SceneManagement is used whenever we need to switch to a different scene, or reload the current one.
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour {
    public float restartDelay = 1f;
    // class/ type GameObject allows us access to methods, and variables pertaining to game objects from our Hierarchy view.
    public PlayerMovement playerMovementScript;
    public PlayerCollision playerCollisionScript;
    public GameObject completeLevelUI;
    
    // EndGame() will be called in instances where the player triggers a game over.
    public void EndGame() {

        if (!playerCollisionScript.isAlive) {
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart() {
        // SceneManager.LoadScene("Level-1");
        // can load scene by name (SceneManager.GetActiveScene().name), or by build index 
        // (SceneManager.GetActiveScene().buildIndex). Best practice is build index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CompleteLevel() {
        Debug.Log("LEVEL ONE COMPLETE!");
        // SetActive(): method from GameObject also us to toggle the presence of the game object on or off.
        playerMovementScript.enabled = false;
        completeLevelUI.SetActive(true);

    }
}
