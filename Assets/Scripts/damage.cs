using UnityEngine;
using System.Collections;

public class damage : MonoBehaviour {

    public float damagee = 50;

    public float GetDamage() {
        return damagee;
    }

    public void Hit() {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(gameObject);
    }

}
