using UnityEngine;
using System.Collections;

public class enemies : MonoBehaviour {
    public GameObject enemyPrefab;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;
    public GameObject enemyPrefab4;
    public GameObject enemyPrefab5;
    float shootsPerSecond = 0.5f;
    public float projectileSpeed = 2;
    public float health = 150;


    void Update() {

        float probability = Time.deltaTime * shootsPerSecond;
        if (Random.value < probability) {
            Spawn();

        }


    }

    private void OnTriggerEnter2D(Collider2D collision) {
        enemyPrefab = enemyPrefab2;
        if (enemyPrefab2) {
          
            if (health <=0) {
                enemyPrefab2 = enemyPrefab3;
            }
        }
    }

    void Spawn() {
        float y = Random.Range(-4, 4);
        float x = 12f;
        float z = 0;
        Vector3 pos = new Vector3(x, y, z);

        transform.position = pos;

        GameObject beama = Instantiate(enemyPrefab, transform.position, Quaternion.identity) as GameObject;
        beama.GetComponent<Rigidbody2D>().velocity = new Vector3(-projectileSpeed, 0, 0);
        

    }
}


