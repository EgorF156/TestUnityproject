using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColors : MonoBehaviour
{
    [SerializeField] private Color[] ballColors;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = ballColors[Random.Range(0, ballColors.Length)];
    }
}
