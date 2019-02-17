using UnityEngine;
using System.Collections;

public class Curving : MonoBehaviour {

    int movingUp, movingDown, ceiling, floor;
    float shootsPerSecond = 0.4f;
    float speed = 5f;
    bool moving = true;



    void Update () {
        if (transform.position.y >= 4) {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-1, -3, 0);
        }
            if (transform.position.y <= -4) {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-1, 3, 0);
                }

        if (moving) { 
        float probability = Time.deltaTime * shootsPerSecond;
        
            if (Random.value < probability) {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-2, 3, 0);
           
        }
            

        
            moving = false;
        }

        else if (moving == false) { 
      
       

        float probability2 = Time.deltaTime * shootsPerSecond;
        if (Random.value < probability2) {
                GetComponent<Rigidbody2D>().velocity = new Vector3(-2, -3, 0);
             
            }
            moving = true;
        }
    }
}
