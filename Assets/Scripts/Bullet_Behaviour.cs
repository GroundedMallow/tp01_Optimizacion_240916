using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Behaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody bulletRb;
    [SerializeField] private float bulletSpeed;

    private void OnEnable()
    {
        bulletRb.velocity = Vector2.up * bulletSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
            //Destroy(collision.gameObject);
            //Destroy(gameObject);

        gameObject.SetActive(false);
    }
}
