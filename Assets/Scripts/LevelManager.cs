using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public GameObject menu;
    bool Pause = false;
    bool created = true;
    bool deleted = true;

    public void Update() {
        
    }


    public void LoadLevel(string name) {
        Application.LoadLevel(name);
    }

    public void QuitRequest() {
        Application.Quit();
    }
  
    public void Resume() {
        if (Pause == false) {

            Time.timeScale = 1;
            var menuu = FindObjectOfType<PlayerController>();
            menuu.menu.SetActive(false);
           
            

        } else {
    
     
            Time.timeScale = 0;
            var menuu = FindObjectOfType<PlayerController>();
            menuu.menu.SetActive(true);
            Pause = false;


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

