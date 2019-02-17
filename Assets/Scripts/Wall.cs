using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Wall : MonoBehaviour {

  
    void OnTriggerEnter2D(Collider2D col) {
        var dakleba = FindObjectOfType<WallHealth>();
        dakleba.DecreaseHealth();
        Destroy(col.gameObject);
    }
 
}
