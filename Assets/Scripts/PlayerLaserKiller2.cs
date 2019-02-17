using UnityEngine;
using System.Collections;

public class PlayerLaserKiller2 : MonoBehaviour {

    
    void OnTriggerEnter2D(Collider2D trigger) {
        Destroy(trigger.gameObject);
    }
}
