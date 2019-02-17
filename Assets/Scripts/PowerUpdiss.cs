using UnityEngine;
using System.Collections;

public class PowerUpdiss : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collid) {
        Destroy(collid.gameObject);
    }
}
