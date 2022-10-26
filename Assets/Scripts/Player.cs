using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    private float duckflyspeed = 4f;
    private Rigidbody ducky;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
        ducky = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();
            ducky.velocity = ducky.velocity + Vector3.up * duckflyspeed;
        }
    }
}
