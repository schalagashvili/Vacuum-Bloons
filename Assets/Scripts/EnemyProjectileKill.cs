using UnityEngine;
using System.Collections;

public class EnemyProjectileKill : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(gameObject);
    }
}
