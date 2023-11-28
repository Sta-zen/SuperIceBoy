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
    public Loose Loose;
    private void Awake2()
    {
        Loose = GetComponent<Loose>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && player.isDashing == true)
        {
            ScoreScript.scoreValue += 1;
            Destroy(gameObject);
            Termometr.fill -= 0.04f;
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(player.gameObject);
            Loose.LooseMen();
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
