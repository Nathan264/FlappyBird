using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rig;
    private Animator anim;

    [SerializeField] 
    private float jump;


    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (GameManager.Instance.isGameOver == true) {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Obstacle")) {
            GameOver();
        }
        if (other.gameObject.CompareTag("Ground")) {
            GameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Pipe")) {
            GameManager.Instance.ScoreUpdate(1);
        }    
    }

    private void GameOver() {
        GameManager.Instance.GameOver();
    }

    private void Jump() {
        rig.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        anim.SetTrigger("Fly");
    }

}
