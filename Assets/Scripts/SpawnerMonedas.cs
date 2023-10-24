using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMonedas : MonoBehaviour
{
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
