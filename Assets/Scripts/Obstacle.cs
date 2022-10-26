﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//This script manages the behavior of individual obstacle
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float Speed = 3;
    public GameObject Ducky;
    public Text Scoretext;
    public int DuckScore = 0;

    void Start()
    {
        Scoretext.GetComponent<Text>().text = "SCORE: 0";
    }

    void Update()
    {
        if (transform.position.x <= -8)
            Destroy(gameObject);
        else
            transform.Translate(Vector3.right * Time.deltaTime * -Speed);

        if (this.transform.position.x < Ducky.transform.position.x)
        {
            DuckScore += 1;
            Scoretext.GetComponent<Text>().text = "SCORE: " + DuckScore;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Die");
        }
    }
}
