using UnityEngine;
using System.Collections;

public class MusicPlayea : MonoBehaviour {
    bool musicOn = true;

	void Start () {
      if (musicOn) {
            DontDestroyOnLoad(gameObject);
            musicOn = false;
        }
	}
	

	void Update () {
	  if(musicOn == false) {
            Destroy(gameObject);
        }
	}
}
