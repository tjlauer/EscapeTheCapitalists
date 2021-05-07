// Created by: Braxton Fair
// Created on: 04/23/2021

using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Create a list of the enemies
    public GameObject[] enemies;

    // The chance that the enemy would be spawned
    public int ifLessThan = 33;
    public int outOf = 100;

    private int spawned = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Get all enemy spawners
        GameObject[] points = GameObject.FindGameObjectsWithTag("EnemySpawner");

        // Loop through each spawn point
        foreach (GameObject spawnPoint in points) {
            // Generate a random chance 
            int spawnChance = Random.Range(0, outOf);

            // If the chance runs
            if (spawnChance < ifLessThan) {
                // Get the random enemy
                int getRandomEnemy = Random.Range(0, enemies.Length);

                // Check there is no lock on spawning
                if (SharedResources.AbleToSpawnEnemies == true)
                {
                    Instantiate(enemies[getRandomEnemy], spawnPoint.transform.position, Quaternion.identity);
                    spawned++;
                }
            }
        }

        // No monsters were spawned, just spawn one at the first point
        if (spawned == 0 && SharedResources.AbleToSpawnEnemies == true)
        {
            int getRandomEnemy = Random.Range(0, enemies.Length);

            Instantiate(enemies[getRandomEnemy], points[0].transform.position, Quaternion.identity);
        }
    }
}
