using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monedero : MonoBehaviour
{
    public static Monedero Instance;
    public TMP_Text TextoMonedas;
    public int coinID = 0;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        TextoMonedas.text = "COINS: " + coinID.ToString();
    }
    public void Wallet(int v)
    {
        coinID += v;
        TextoMonedas.text = "COINS: " + coinID.ToString();
        if (coinID == 10)
        {
            SceneManager.LoadScene("Victoria");
        }
    }
}
