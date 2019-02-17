using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
    private void Update() {


        bool Pause = true;
        if (Pause == false) {
     
            Time.timeScale = 1;
            
        } else {

            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.P)) {
            if (Pause == true) {
                Pause = false;
                

            } else {
                Pause = true;
            }
        }
    }
}
