using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Coin : MonoBehaviour
{
    [Header("Coin")]
    private Rigidbody2D rb2D;
    public int value = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        transform.Translate(Vector3.up * 0 * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, 3f);
            Monedero.Instance.Wallet(value);
        }
    }
}