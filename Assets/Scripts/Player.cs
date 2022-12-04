using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 jumpForce;
    Vector2 currentVelocity;
    Rigidbody2D rgbd;
    GameManager gameManager;
    ScoreUI scoreUI;

    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        rgbd.gravityScale = 0;
        gameManager = FindObjectOfType<GameManager>();
        scoreUI = FindObjectOfType<ScoreUI>();
    }

    void Update()
    {
        if (gameManager.gameOver) { rgbd.bodyType = RigidbodyType2D.Static;return; }
        if (Input.GetMouseButtonDown(0))
        {
            if (rgbd.gravityScale != 0.5f) { rgbd.gravityScale = 0.5f; }
            rgbd.AddForce(jumpForce);
            SpeedController();
            scoreUI.IncrementScore(1);
        }
    }

    void SpeedController()
    {
        currentVelocity = rgbd.velocity;
        currentVelocity.x = Mathf.Clamp(currentVelocity.x, 2, 2);
        currentVelocity.y = Mathf.Clamp(currentVelocity.y, 2, 2);
        rgbd.velocity = currentVelocity;
    }
}
