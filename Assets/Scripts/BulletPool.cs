using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private int poolSize = 5;

    [SerializeField] private List<GameObject> bulletList;

    //set ONE instance for pool
    private static BulletPool instance;
    private static BulletPool Instance {  get { return instance; } }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        AddBulletsToPool(poolSize);
    }

    private void AddBulletsToPool(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            //sets defaultBullet for every item in list, not active 
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.SetActive(false);

            bulletList.Add(bullet); //activates bullets
            bullet.transform.parent = transform;
        }
    }

    public GameObject RequestBullet()
    {
        //find first inactive object in list, activate and send
        for(int i = 0; i < bulletList.Count; i++)
        {
            if (!bulletList[i].activeSelf)
            {
                bulletList[i].SetActive(true);
                return bulletList[i];
            }
        }

        //if no inactive objects
        return null;
    }
}
