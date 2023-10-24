using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class SpawnerMonedas : MonoBehaviour
{
    float x;
    float y;
    Vector2 pos;
    [Header("Coin Attributes")]
    public GameObject coin;
    public float lifeTime = 1f;

    [Header("Spawner Attributes")]
    [SerializeField] private float SpawningRate = 1f;

    private GameObject spawnedCoin;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(-25, 26);
        y = Random.Range(-25, 26);
        pos = new Vector3(x, y);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= SpawningRate)
        {
            Spawnear();
            timer = 0;
        }
    }

    private void Spawnear()
    {
        if (coin)
        {
            spawnedCoin = Instantiate(coin, transform.position, Quaternion.identity);
            spawnedCoin.transform.rotation = transform.rotation;
        }
    }
}
