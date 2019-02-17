using UnityEngine;
using System.Collections;
using System;

public class ProjectileThird : MonoBehaviour {
    public AudioClip cracka;
    public float health = 150;
    public int scoreValuee = 5;
    public float damage = 50;
    private ScoreToWin scoreKeeper2;



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
           
            health -= missile.GetDamage();
           
            missile.Hit();
            if (health <= 0) {
                var bushtia = FindObjectOfType<enemies>();

                Destroy(gameObject);
                
                GameObject beama = Instantiate(bushtia.enemyPrefab2, transform.position, Quaternion.identity) as GameObject;
                beama.GetComponent<Rigidbody2D>().velocity = new Vector3(-2, 0, 0);
                    
                scoreKeeper2 = FindObjectOfType<ScoreToWin>();
                scoreKeeper2.Score(scoreValuee);


            }

        }

    }


}