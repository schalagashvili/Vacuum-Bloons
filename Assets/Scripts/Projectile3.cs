using UnityEngine;
using System.Collections;
using System;

public class Projectile3 : MonoBehaviour {
    public AudioClip cracka;
    public float health = 150;
    public int scoreValuee = 150;
    public int points;
    public float damage = 50;
    public GameObject bushti2;
    public GameObject bushti3;
    public Sprite[] bloons;
    public static GameObject[] myObjects;
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

        damage missile = collider.gameObject.GetComponent<damage>();

        if (missile) {
           
            health -= missile.GetDamage();
           
            missile.Hit();
            if (health <= 0) {
                var bushtia = FindObjectOfType<enemies>();

                Destroy(gameObject);

                GameObject beama = Instantiate(bushtia.enemyPrefab2, transform.position, Quaternion.identity) as GameObject;
                beama.GetComponent<Rigidbody2D>().velocity = new Vector3(-2, 0, 0);



                AudioSource.PlayClipAtPoint(cracka, transform.position);


                scoreKeeper22 = FindObjectOfType<ScoreToWin>();
                scoreKeeper22.Score(scoreValuee);
            }

        }

    }


}