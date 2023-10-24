using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetCoins : MonoBehaviour
{
    GameObject Moneda;
    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Wallet()
    {
        if (contador == 10)
        {
            SceneManager.LoadScene("Victoria");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int cantidad = Moneda.GetComponent<Coin>().cant;
        contador += cantidad;
    }
}
