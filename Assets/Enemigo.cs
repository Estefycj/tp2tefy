using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int numberOfEnemies = 5;
    private int enemiesSpawned = 0;

    void Start()
    {
        // Bucle para instanciar varios enemigos
        for (int i = 0; i < numberOfEnemies; i++)
        {
            // Generar una posición aleatoria para cada enemigo
            Vector3 randomPosition = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
            
            // Instanciar el enemigo en la posición aleatoria
            Instantiate(enemyPrefab, randomPosition, Quaternion.identity);

            break;

        }
        
    }

    void Update()
    {
        
    }
}



