using UnityEngine;
using System.Collections;

public class laserDissap : MonoBehaviour {

  
        void OnTriggerEnter2D(Collider2D trigger) {
        Destroy(gameObject);
    }
}
