
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour {

    public GameManage gameManager;
    // if collider is marked as trigger we can no longer use onCollisionEnter() because it can no longer collide. It is now a trigger, so we use onTriggerEnter()
    void OnTriggerEnter(Collider collider) {

        if (collider.name == "Player") {
            gameManager.CompleteLevel();
        }
    }
}
