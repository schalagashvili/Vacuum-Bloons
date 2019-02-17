using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WallHealth : MonoBehaviour {

    public int health = 500;
    int damage = 50;
    private Text myText;
    void Start() {
        myText = GetComponent<Text>();
    }
    public void DecreaseHealth() {
        health -= damage;
        myText.text = health.ToString();
        if (health <= 0) {
            var wall = FindObjectOfType<Wall>();
            Destroy(wall.gameObject);
        }
    }
}
