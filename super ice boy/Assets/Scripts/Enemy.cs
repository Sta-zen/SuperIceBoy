using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float speed;

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
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            currentPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
            {
            currentPoint = pointB.transform;
        }

    }
    public void Setactive()
    {
        gameObject.SetActive(false);
    }



}
