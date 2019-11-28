using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthFuelPlayer : MonoBehaviour
{
    private GameObject PlayerStar;
    public static float PlayerHealth = 100f;
    private float HealthTickTimer;
    public static float HealthDamage = 0.1f;
    private float ScoreKeeper = CloudPickUp.ScoreFromCloud;
    public static bool BackToMenuSwitch;
   
    //Handles the playerobject, sets the player object active upon start,
    //also sets the backtomenuswitch to false.
    private void Start()
    {
        BackToMenuSwitch = false;
        PlayerStar = GameObject.FindGameObjectWithTag("PlayerStar");
        PlayerStar.SetActive(true);
    }

    // Handles the playerhealth decrease, and if low enough, sets the playerobject
    // to inactive. Also sets the backtomenu swith to true.
    private void Update()
    {

        HealthTickTimer += Time.deltaTime;
        if (PlayerHealth > 0f)
        {
            if (HealthTickTimer >= 0.2f)
            {
                PlayerHealth = PlayerHealth - HealthDamage;
                HealthTickTimer = 0f;
            }
            if (PlayerHealth <= 0f)
            {
                PlayerStar.SetActive(false);
                BackToMenuSwitch = true;
            }
        }
        if (PlayerHealth < 0f)
        {
            PlayerHealth = 0f;
        }
    }
}
