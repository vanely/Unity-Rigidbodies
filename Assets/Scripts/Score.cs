using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public Transform player;
    public PlayerCollision playerCollisionScript;
    public Text scoreText;
    public GameManage gameManager;
    int finalScore;
    int playerZToInt;

    // Update is called once per frame
    void Update() {
        // Convert.ToInt32(player.position.z);
        // another approach
        playerZToInt = (int) player.position[2];
        if (playerZToInt < 0) {
            scoreText.text = "0";
        } else {
            // instead of casting the float into an int as done above.
            // one could equally do this. -> player.position.z.toString("0");
            scoreText.text = playerZToInt.ToString();
        }
        
        if (!playerCollisionScript.isAlive) {
            // should say this when when object is hit not when script is disable
            scoreText.text = "YOU FUCKING SUUUUCK!!!";
        }
    }
}
