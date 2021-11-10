using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMechanics : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject firePoint;
    public bool fire;
    bool readToFire;
    int bulletsInMagazine;
    float bulletSpeed = 20f;
    float reloadTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        fire = false;
        readToFire = true;
        bulletsInMagazine = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (fire)
        {
            FireTheBullet();
        }
    }

    void FireTheBullet()
    {
        if (readToFire)
        {
            GameObject temp =  Instantiate(bullet);
            temp.transform.position = firePoint.transform.position;
            temp.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed, 0f);
            readToFire = false;
            bulletsInMagazine -= 1;
            if(bulletsInMagazine == 0)
            {
                StartCoroutine(GunReload());
                 
            }
            else
            {
                Invoke("BulletInChamber", 0.25f);
            }
            StartCoroutine(DestroyBullet(temp));
        }
        
    }

    IEnumerator DestroyBullet(GameObject bullet)
    {
        yield return new WaitForSeconds(5);
        Destroy(bullet);
    }

    void BulletInChamber()
    {
        readToFire = true;
    }

    IEnumerator GunReload()
    {
        yield return new WaitForSeconds(reloadTime);
        bulletsInMagazine = 10;
        readToFire = true;
    }
}
