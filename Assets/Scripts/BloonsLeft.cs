using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BloonsLeft : MonoBehaviour {


    // ამ პროექტში, კოდების რამდენიმე ფრაგმენტი გამოყენებულია ამ ტუტორიალის (https://www.udemy.com/unitycourse/) მე-2 თამაშიდან სახელად: Laser Defender.
    // კოსმოსის უკანა background-იც მაგ თამაშიდან არის აღებული.
    // ანუ, Unity-ის მაგ ტუტორიალეის ყურებისას შევქმენი Laser Defender თამაში, რომელზეც 'დავაშენე' ფაქტიურად ეს ჩემი თამაში(Vacuum Bloons). 

    public int bloons = 5;
    public Text myText;
	
	void Start () {
        myText = GetComponent<Text>();
	}

    public void Crashed() {
        bloons -= 1;
        myText.text = bloons.ToString();
        if(bloons <= 0) {
            bloons = 1;
            var defeat = FindObjectOfType<LevelManager>();
            defeat.LoadLevel("Lose");
        }
    }
   

    void Update () {
	
	}
}
