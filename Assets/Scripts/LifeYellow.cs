using UnityEngine;
using System.Collections;

public class LifeYellow : MonoBehaviour {

    float life = 100;

	public void OnTriggerEnter2d(Collider2D col) {
        life -= 50;
    }
}
