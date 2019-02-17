using UnityEngine;
using System.Collections;

public class lifee : MonoBehaviour {
    float life = 100;

    public void OnTriggerEnter2D(Collider2D collision) {
        life -= 50;
        if(life <= 0) {
            Destroy(gameObject);
        }
    }
}
