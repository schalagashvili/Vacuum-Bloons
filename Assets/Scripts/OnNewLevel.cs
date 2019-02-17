using UnityEngine;
using System.Collections;

public class OnNewLevel : MonoBehaviour {

	void Start () {
        Destroy(gameObject, 2.0f);
    }

}
