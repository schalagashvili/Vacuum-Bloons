using UnityEngine;
using System.Collections;
using System;

public class YellowBloons : MonoBehaviour {
    public AudioClip cracka;
    public float health = 30;
    public int scoreValuee = 5;
    public int points;
    public float damage = 50;
    public GameObject bushti2;
    public GameObject bushti3;
    public Sprite[] bloons;
    public static GameObject[] myObjects;
    private ScoreKeeper scoreKeeper;
    private ScoreToLevel3 scoreKeeper2;
    private ScoreToWin scoreKeeper22;
    private bool respawned = true;

    public GameObject[] items;
    void Start() {
        GameObject scoreKeeper = GameObject.Find("Score") as GameObject;
    }
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D collider) {
        health -= damage;
        AudioSource.PlayClipAtPoint(cracka, transform.position);
        damage missile = collider.gameObject.GetComponent<damage>();
        if (missile) {
            missile.Hit();
            if (health <= 0) {
                var bushtia = FindObjectOfType<enemies>();
                Destroy(gameObject);
                
                scoreKeeper22 = FindObjectOfType<ScoreToWin>();
                scoreKeeper22.Score(scoreValuee);
            }
        }
    }
}