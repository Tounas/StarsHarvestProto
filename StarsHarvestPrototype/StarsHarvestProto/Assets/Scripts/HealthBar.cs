using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private Transform HealthBarPlayer;
    private float HealthToHealthBar;

    //Searches for the object that has "bar" tag.
    private void Start()
    {
        HealthBarPlayer = transform.Find("Bar");
    }

    //Handles the health bar modification.
    public void SetSizeBar(float SizeX)
    {
        HealthBarPlayer.localScale = new Vector3(SizeX / 100, 1f);
    }

    //takes the health from healthfuelplayer script, and modifies the bar size by calling the function.
    private void Update()
    {
        HealthToHealthBar = HealthFuelPlayer.PlayerHealth;
        SetSizeBar(HealthToHealthBar);
    }
}
