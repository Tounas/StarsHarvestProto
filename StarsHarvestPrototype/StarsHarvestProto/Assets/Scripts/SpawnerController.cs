using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnerController : MonoBehaviour
{
    public GameObject[] Spawners;
    private float SpawnerEnableTimer = 0f;
    private float ModifiableTimer = 1f;
    private float BackToMenuTimer;

    //Finds all the spawners tagged as spawners, creates an array and sets the spawners inactive
    private void Awake()
    {
        BackToMenuTimer = 0f;
        Spawners = GameObject.FindGameObjectsWithTag("Spawner");
        foreach (GameObject SpawnerFound in Spawners)
        {
            SpawnerFound.SetActive(false);
        }

    }

    //Keeps track for the timer (when to spawn)
    void Update()
    {
        SpawnerEnableTimer += Time.deltaTime;
        if (SpawnerEnableTimer >= ModifiableTimer)
        {
            SpawnerCall();
            SpawnerEnableTimer = 0;
        }
        if (HealthFuelPlayer.BackToMenuSwitch == true)
        {
            BackToMenuTimer += Time.deltaTime;
            if (BackToMenuTimer >= 3f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
    }

    //Randomisation for spawner pickup (which spawner spawns)
    void SpawnerCall()
    {
        float ArraySize = Random.Range(0, Spawners.Length);
        int arrayIndex = ((int)ArraySize % Spawners.Length);
        Spawners[arrayIndex].SetActive(true);
    }
}
