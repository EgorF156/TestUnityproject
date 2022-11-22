using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
     [SerializeField] private Rigidbody platformRigid;

    [SerializeField] private int speed;

    private void Start()
    {
        platformRigid = GetComponent<Rigidbody>();
        speed = 0;
    }

    private void FixedUpdate()
    {
        platformRigid.velocity = Vector3.right * speed * Time.deltaTime;
    }

    private void Update()
    {
        ArrowControl();
    }

    private void ArrowControl()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            speed = 450;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            speed = -450;
        }
    }
}
