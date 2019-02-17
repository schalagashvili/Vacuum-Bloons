using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour {

    int health = 150;
    int damage = 50;
    private Text myText;

    void Start() {
        myText = GetComponent<Text>();
    }

    public void DecreaseHealth() {
        health -= damage;
        myText.text = health.ToString();
        if(health <= 0) {
            var lvl = FindObjectOfType<LevelManager>();
            lvl.LoadLevel("Lose");
        }
    }

}
