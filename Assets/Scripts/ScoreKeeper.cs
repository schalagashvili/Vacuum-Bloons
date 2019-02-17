using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {
    public static int scoree = 0;
    private Text myText;


    void Start() {
        
     myText =   GetComponent<Text>();
        Reset();
    }
    void Update() {
        { 
   
    }
    }

    public void Score(int points) { 
         scoree += points;
        if(scoree >= 4050) {
            var win = FindObjectOfType<LevelManager>();
            win.LoadLevel("Level_02");
        }
        myText.text = scoree.ToString();
      
    }
  


    public static void Reset() {
        scoree = 0;
    }


  
}
