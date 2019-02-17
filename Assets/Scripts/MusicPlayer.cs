using UnityEngine;
using System.Collections;
using System;

public class MusicPlayer : MonoBehaviour {


    public AudioClip startClip;
    public AudioClip gameClip;
    public AudioClip endClip;

    private AudioSource music;
    static MusicPlayer instance = null;

    void Awake() {
        if (instance != null) {
            //ობიექტის განადგურება.
            Destroy(gameObject);
        } else {
            instance = this;
            //ობიექტის არ განადგურება.
            DontDestroyOnLoad(gameObject);
            music = GetComponent<AudioSource>();
            music.clip = startClip;
            music.loop = true;
            music.Play();
        }
    }

    //ლეველის ჩატვირთვისას გამოიყენება ეს ფუნქცია.
    void OnLevelWasLoaded(int level) {
        Debug.Log("Music Player Loaded level" + level);
        //მუსიკის გამორთვა (ჩაშნ, ფუნქცია).
            music.Stop();
        if(level == 1) {
            music.clip = startClip;
        }
        if (level == 2) {
            music.clip = gameClip;
        }
        if (level == 3) {
            music.clip = endClip;
        }


        music.loop = true;
        music.Play();
    }

    void Start() {
    }
}
