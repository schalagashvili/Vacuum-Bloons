using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class SilverBloon : MonoBehaviour {
    public AudioClip cracka;
    public float health = 150;
    public int scoreValuee = 5;
    public int points;
    public float damage = 250;
    public GameObject bushti2;
    public GameObject bushti3;
    public Sprite[] bloons;
    public static GameObject[] myObjects;
    private ScoreKeeper scoreKeeeper;
    private ScoreToWin scoreKeeper2;
    private bool respawned = true;

    public GameObject[] items;
    void Start() {
        GameObject scoreKeeper = GameObject.Find("Score") as GameObject;
    }
  

    void OnTriggerEnter2D(Collider2D collider) {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        health -= damage;
        AudioSource.PlayClipAtPoint(cracka, transform.position);
        damage missile = collider.gameObject.GetComponent<damage>();

        if (missile) {
           
            health -= missile.GetDamage();
            
            missile.Hit();
            if (health <= 0) {
                var bushtia = FindObjectOfType<enemies>();

                Destroy(gameObject);

                scoreKeeper2 = FindObjectOfType<ScoreToWin>();
                scoreKeeper2.Score(scoreValuee);
               
                if (sceneName != "Game") { 
                GameObject beama = Instantiate(bushtia.enemyPrefab4, transform.position, Quaternion.identity) as GameObject;
                beama.GetComponent<Rigidbody2D>().velocity = new Vector3(-2, 0, 0);
                }
                






            }

        }

    }


}