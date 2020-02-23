using UnityEngine;
using UnityEngine.SceneManagement;

// in the animation that we have created for the LevelComplete object, we have added an AnimationEvent at the 2 second mark. We want to be able to trigger the next level to be loaded once the current level being played is complete. We have to add the script for this functionality directly on the object that is being animated. In our case, the LevelComplete object. The methods from this script will now be available to us in the select funtion from our created AnimationEvent.
public class LevelComplete : MonoBehaviour {
    public void LoadNextLevel() {
        // best practice is to pass the next scene as it's build index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
