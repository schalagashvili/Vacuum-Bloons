using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EarnedPoints : MonoBehaviour {


    void Start() {
        Text myText = GetComponent<Text>();
        myText.text = ScoreToWin.scoree.ToString();
        
    }
}
