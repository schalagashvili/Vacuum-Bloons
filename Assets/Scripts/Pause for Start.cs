using UnityEngine;
using System.Collections;

public class PauseforStart : MonoBehaviour {
    private void Update() {


        bool Pause = true;
        if (Pause == false) {
            Time.timeScale = 1;

        } else {
            Time.timeScale = 0;
            var pause = FindObjectOfType<LevelManager>();
            pause.LoadLevel("Start Menu");


        }


        if (Input.GetKeyDown(KeyCode.P)) {
            if (Pause == true) {
                Pause = false;
                var pausea = FindObjectOfType<LevelManager>();
                pausea.LoadLevel("Lose");

            } else {
                Pause = true;
            }
        }
    }
}
