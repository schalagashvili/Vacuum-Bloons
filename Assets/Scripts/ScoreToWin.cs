using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScoreToWin : MonoBehaviour {
    public static int scoree = 0;
    private Text myText;


    void Start() {
        scoree = 0;
        myText = GetComponent<Text>();
        
    }


    public void Score(int points) {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        scoree += points;
        myText.text = scoree.ToString();
        if (scoree >= 500 && sceneName == "Game") {
            var win = FindObjectOfType<LevelManager>();
            win.LoadLevel("Level_02");
        } 
        else if (scoree >= 800 && sceneName == "Level_02") {
            var win = FindObjectOfType<LevelManager>();
            win.LoadLevel("Level_03");


            myText.text = scoree.ToString();

        }

    }
}
