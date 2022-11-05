using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject pipe;
    [SerializeField] private float interval;

    private void Start() {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn() {
        while (!GameManager.Instance.isGameOver) {
            Instantiate(pipe, new Vector3(-2, Random.Range(-2.6f, 2f), 0), pipe.transform.rotation);
            yield return new WaitForSeconds(interval);
        }
    }
}
