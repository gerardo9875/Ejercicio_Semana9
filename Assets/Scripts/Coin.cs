using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Coin : MonoBehaviour
{
    [Header("Coin")]
    private Rigidbody2D rb2D;
    public int cant = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * 0 * Time.deltaTime);
        Destroy(gameObject, 3f);
    }
}