using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    public float speed = 2.0f;

    void Update()
    {
        Vector3 direction = Vector3.zero;
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump")) direction.y = 20;

        Vector3 velocity = direction * speed;
        transform.position += velocity * Time.deltaTime;
    }
}
