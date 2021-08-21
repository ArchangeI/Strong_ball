using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject powerUp;
    public int enemyCount;
    private float spawnRange = 9.0f;
    private int waveNumber = 1;
    private PlayerController playerCon;

    void Start()
    {
        SpawnEnemyWave(waveNumber);
        SpawnPowerUp();
        playerCon = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length; //Вертає довжину масиву обєктів до якого привязаний клас

        if(enemyCount == 0 && !playerCon.gameOver)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            SpawnPowerUp();
        }
    }

    void SpawnEnemyWave(int enemyToSpawn)
    {
        for (int i = 0; i < enemyToSpawn; i++)
        {
            Instantiate(enemy, GenerateRandomPos(), enemy.transform.rotation);
        }
    }

    void SpawnPowerUp()
    {
        Instantiate(powerUp, GenerateRandomPos(), powerUp.transform.rotation);
    }

    private Vector3 GenerateRandomPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}
