using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        if (GameManager.Instance.isGameOver == true) {
            return;
        }
        
        if (transform.position.x < -10) {
            Destroy(gameObject);
        }

        Move();
    }

    private void Move() {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
