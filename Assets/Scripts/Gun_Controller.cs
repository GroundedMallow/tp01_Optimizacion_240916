using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Controller : MonoBehaviour
{
    //[SerializeField] private GameObject bulletPrefab;
    //[SerializeField] private Transform bullet_SpawnPoint;

    BulletPool _bulletPool;
    [SerializeField] private float bulletOffset;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            //Instantiate(bulletPrefab, bullet_SpawnPoint.position, bullet_SpawnPoint.rotation);

            GameObject bullet = _bulletPool.RequestBullet();
            bullet.transform.position = transform.position + Vector3.forward * bulletOffset;
        }
    }
}
