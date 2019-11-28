using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloudPickUp : MonoBehaviour
{
    public static float ScoreFromCloud = 0;
    private Text ScoreText;
    public static float PlayerHealthPickUp = 5f;

    //Search for Scoretext holder with tag
    private void Start()
    {
        ScoreText = GameObject.FindGameObjectWithTag("ScoreText").gameObject.GetComponent<Text>();
        
    }

    //When collides with other, destroys other object, increases score, and modifies player health
    //Also modifies the score text to display score.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        ScoreFromCloud++;
        HealthFuelPlayer.PlayerHealth = HealthFuelPlayer.PlayerHealth + PlayerHealthPickUp;
        if (HealthFuelPlayer.PlayerHealth > 100)
        {
            HealthFuelPlayer.PlayerHealth = 100;
        }
        ScoreText.text = "Score: " + ScoreFromCloud;
    }
}
