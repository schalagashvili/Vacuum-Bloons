using UnityEngine;
using System.Collections;

public class PowerupSpawner : MonoBehaviour {
    public GameObject enemyPrefab;
    float shootsPerSecond = 0.08f;
    public float projectileSpeed = 2;


    void Start () {
	
	}
	

	void Update () {
        
        float probability = Time.deltaTime * shootsPerSecond;
        if (Random.value < probability) {
            Spawn();
            
        }

    
 }

    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(gameObject);
    }


    void Spawn() {
      float  y = Random.Range(-4, 4);
       float x = 12f;
        float z = 0;
        Vector3 pos = new Vector3(x, y, z);
      
        transform.position = pos;

        GameObject beama = Instantiate(enemyPrefab, transform.position, Quaternion.identity) as GameObject;
        beama.GetComponent<Rigidbody2D>().velocity = new Vector3(-projectileSpeed, 0, 0);

    }
    }


