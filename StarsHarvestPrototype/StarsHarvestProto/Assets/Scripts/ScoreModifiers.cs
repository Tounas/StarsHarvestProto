using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreModifiers : MonoBehaviour
{
    public static bool HasBeenDone = false;
    private float Scorekeeper;
    private float DividerDifficulty = 7;
    

    // Handles the difficulty modification in the game by taking the score from other script,
    // and changes various variables to alter the flow of the game.
    void Update()
    {
        Scorekeeper = CloudPickUp.ScoreFromCloud;
        if (Scorekeeper > 0 && Scorekeeper % DividerDifficulty != 0)
        {
            HasBeenDone = false;
        }

        if (Scorekeeper > 0 && Scorekeeper % DividerDifficulty == 0 && HasBeenDone == false)
        {
            CloudPickUp.PlayerHealthPickUp *= 1.05f;
            PlayerController.Speed *= 1.1f;
            HealthFuelPlayer.HealthDamage *= 1.2f;
            GasCloudMovement.Speed *= 1.2f;
            HasBeenDone = true;
        }
    }
}
