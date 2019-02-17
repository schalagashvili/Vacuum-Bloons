using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreToLevel3 : MonoBehaviour {
    public static int scoree = 0;
    private Text myText;


    void Start() {

        myText = GetComponent<Text>();
       
    }
    void Update() {
        {

        }
    }

    public void Score(int points) {
        scoree += points;
        myText.text = scoree.ToString();
        if (scoree == 2000) {
            var win = FindObjectOfType<LevelManager>();
            win.LoadLevel("Level_03");
        }
        if(scoree == 4000) {

        }
       

    }



  



}
