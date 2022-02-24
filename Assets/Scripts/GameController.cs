using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float time;
    public bool play;
    private Rigidbody Player;
    private float moveSpeed;
    private Spawner spn;
    

    // Use this for initialization
    void Start()
    {
        play = true;
        time = 0;
        moveSpeed = -0.1f;
        Player = GetComponent<Rigidbody>();
        spn = GetComponent<Spawner>();
    }


    void FixedUpdate()
    {
        time++;
        if (play)
        {
            if (time <= 3000)
            {
                Player.velocity = new Vector3(0, 0, moveSpeed * (time / 50));
            }
            if (Player.velocity.z >= 1 && Player.velocity.z % 10 == 0) {
                spn.Spawn();
            }
        }
    }
}