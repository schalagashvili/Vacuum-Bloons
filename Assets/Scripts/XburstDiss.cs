using UnityEngine;
using System.Collections;

public class XburstDiss : MonoBehaviour {
    bool bursted = true;

	void Start () {
	
	}
	

	void Update () {
        if (Input.GetKeyDown(KeyCode.X)) {
            Destroy(gameObject);
          
        }

	}
}
