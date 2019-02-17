using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject enemyPrefab;
    public float width = 10f;
    public float height = 5f;
    public float speed = 5f;
    public float padding = 0.5f;
    float xmin = -9, xmax = 9;
    bool moving = true;
    void Start() {

    }

    void Update() {

      
        float FormationRightEdge = transform.position.x + (0.5f * width);
        float FormationLeftEdge = transform.position.x - (0.5f * width);

        if (moving) {
            transform.position += Vector3.left * speed * Time.deltaTime;
        } else {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }


        if (FormationLeftEdge < xmin) {
            moving = false;
        }
        if (FormationRightEdge > xmax) {
            moving = true;
        }

     

    }
    void OnCollisionEnter2D(Collision2D collision) {
            Destroy(gameObject);
    }

   

 
}

