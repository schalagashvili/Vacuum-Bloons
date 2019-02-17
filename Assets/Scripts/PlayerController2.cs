using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;


public class PlayerController2 : MonoBehaviour {
    public AudioClip laser;
    public float speed = 5f;
    public float padding = 0.5f;
    float xmin, xmax;
    float damage = 100;
    //როდესაც ვქმნით GameObject -ს სკრიპტში, იმ ობიექტს რომელსაც ეს კოდი უგდია გაუჩნდება ამ სახელწოდების prefab-ის ჩასაგდები მარჯვნივ
    //ავიღებთ იმ prefabs და ჩავაგდებთ და აუცილებლად apply-ს უნდა დავაჭიროთ მარჯვნივ ზემოთ.
    public GameObject projectile;
    public GameObject projectile2;
    public float projectileSpeed;
    public float firingRate = 0.02f;
    private LevelManager levelManager;
    private Health sicocxle;
    bool Pause = false;
    bool burst = true;
    bool created = true;
    bool deleted = true;
    public GameObject menu;
    //??? public ???
    float health = 250;
    void Start() {
        //?????
        float distance = transform.position.z - Camera.main.transform.position.z;
        Vector3 leftMost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 rightMost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));
        xmin = leftMost.x + padding;
        xmax = rightMost.x - padding;

        menu.SetActive(false);
    }


    void fire() {

        Vector3 offset = new Vector3(1, 0, 0);        GameObject beam = Instantiate(projectile, transform.position + offset, Quaternion.identity) as GameObject;
        beam.GetComponent<Rigidbody2D>().velocity = new Vector3(projectileSpeed, 0, 0);
    }







    public void DestroyAllObjects() {
        var gameObjects = GameObject.FindGameObjectsWithTag("Player");

        for (var i = 0; i < gameObjects.Length; i++) {
            Destroy(gameObjects[i]);
            var score = FindObjectOfType<ScoreKeeper>();
            score.Score(100);

        }
    }

    public void Resume() {
        Time.timeScale = 1;
        menu.SetActive(false);
        Pause = false;

    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.X) && burst) {
            DestroyAllObjects();
            burst = false;
        }

        if (Pause == false) {

            Resume();
            Pause = false;
        } else {
            Time.timeScale = 0;
            menu.SetActive(true);

        }


        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape)) {
            if (Pause == true) {
                Pause = false;

            } else {
                Pause = true;
            }
        }




        if (Input.GetKeyDown(KeyCode.Space)) {
            
            InvokeRepeating("fire", 0.00001f, firingRate);
            AudioSource.PlayClipAtPoint(laser, transform.position);
        }
       
        if (Input.GetKeyUp(KeyCode.Space)) {
            CancelInvoke("fire");
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
           

            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        
        else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
      
        else if (Input.GetKey(KeyCode.UpArrow)) {
            transform.position += Vector3.up * speed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
      
        float newx = Mathf.Clamp(transform.position.x, -9.1f, -7.23f);
        float newy = Mathf.Clamp(transform.position.y, -4.2f, 4.3f);
        transform.position = new Vector2(newx, newy);

    }


    void OnTriggerEnter2D(Collider2D col) {
      
        LaserPower PowerUp = col.gameObject.GetComponent<LaserPower>();
        if (PowerUp == false) {
            health -= damage;
            sicocxle = FindObjectOfType<Health>();
            sicocxle.DecreaseHealth();
            if (health <= 0) {
                Die();

            }
        } else {

            Destroy(PowerUp);
            projectile = projectile2;

        }
    }




    void Die() {
        Destroy(gameObject);
        levelManager = FindObjectOfType<LevelManager>();
        levelManager.LoadLevel("Lose");

    }
}

