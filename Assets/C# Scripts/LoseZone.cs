using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseZone : MonoBehaviour
{
    [SerializeField] private int fallObjects;
    [SerializeField] private Text fallObjectsText;

    [SerializeField] private GameObject loseZone;

    private void Start()
    {
        fallObjects = 0;
        fallObjectsText.text = "Fall Objects: " + fallObjects.ToString();
    }

    
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        fallObjects++;
        fallObjectsText.text = "Fall Objects:" + fallObjects.ToString();


        if (fallObjects == 30)
        {
            Time.timeScale = 0;
            loseZone.SetActive(true);
        }
    }
}
