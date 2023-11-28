using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public PlayerMovement player;
    public Termometr Termometr;
    private void Awake()
    {
        Termometr = GetComponent<Termometr>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && player.isDashing == true)
        {
            Destroy(gameObject);
            Termometr.fill -= 0.04f;
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }

    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Setactive()
    {
        gameObject.SetActive(false);
    }
}
