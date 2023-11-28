using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Termometr : MonoBehaviour
{
    public PlayerMovement PlayerMovement;
    public Image bar;
    public static float fill;
    // Start is called before the first frame update

    public void Awake()
    {
        PlayerMovement = GetComponent<PlayerMovement>();
    }
    void Start()
    {
        fill = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        fill += Time.deltaTime * 0.005f;
        bar.fillAmount = fill;
        if (fill <= 0.25f)
        {
            PlayerMovement.dashingPower = 50f;
            PlayerMovement.speed = 16f;
            PlayerMovement.maxJumps = 3;
        }
        else if (fill >= 0.25f)
        {
            PlayerMovement.dashingPower = 35f;
            PlayerMovement.maxJumps = 2;
            PlayerMovement.speed = 12f;
        }
        else if (fill >= 0.75f)
        {
            PlayerMovement.speed = 4f;
        }
    }
}
