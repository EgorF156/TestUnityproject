using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancherZone : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text finishScoreText;

    [SerializeField] private GameObject ballPS;

    private void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score.ToString();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent (out Rigidbody rigidbody))
        {
            Instantiate(ballPS, other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);

            score++;
            scoreText.text = "Score: " + score.ToString();
            finishScoreText.text = score.ToString();

            PlayerPrefs.SetInt("Score", score);
        }
    }
}
