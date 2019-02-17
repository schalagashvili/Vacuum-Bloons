using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D trigger) {
        Destroy(trigger.gameObject);
        var baloons= FindObjectOfType<BloonsLeft>();
        baloons.Crashed();
    }
}
