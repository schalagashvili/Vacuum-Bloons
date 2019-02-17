using UnityEngine;
using System.Collections;

public class poziciebi : MonoBehaviour {

    public GameObject fabb;
	void Start () {
		foreach(Transform chiild in transform) {
            GameObject fab = Instantiate(fabb, chiild.transform.position, Quaternion.identity) as GameObject;
            fab.transform.parent = chiild;
        }
        
	}
	

	void Update () {

	}
}
