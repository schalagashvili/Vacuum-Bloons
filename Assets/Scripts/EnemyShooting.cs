using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour {
    public GameObject projectile;
    public float projectileSpeed = 3;
    public float firingRate = 0.02f;
    public float health = 250;
    public float shootsPerSecond = 0.1f;
    public AudioClip laser;
    
    

    private int timesHit;
    void Start() {

    }


    void Update() {
      
        float probability = Time.deltaTime * shootsPerSecond;
        if (Random.value < probability) {
            fire();
            AudioSource.PlayClipAtPoint(laser, transform.position);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision) {
        health -= 50;
        if (health <= 0) {
            Destroy(gameObject);
        }
    }




    void fire() {
   
        Vector3 startPosition = transform.position + new Vector3(-1, 0, 0);

        GameObject beam = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
        beam.GetComponent<Rigidbody2D>().velocity = new Vector3(-projectileSpeed, 0, 0);
   
    }
}
