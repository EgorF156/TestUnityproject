using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform[] ballPositions;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.2f, 1f));
            Instantiate(ballPrefab, ballPositions[Random.Range(0, ballPositions.Length)].position, Quaternion.identity);
        }
    }
}
