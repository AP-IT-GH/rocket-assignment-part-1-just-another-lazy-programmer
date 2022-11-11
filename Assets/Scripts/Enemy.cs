using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject BulletPrefab;
    public int InitialDelay;
    public float TimeBetweenBullets;
    public float BulletLifetime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireBullet());
    }

    IEnumerator FireBullet()
    {
        yield return new WaitForSeconds(InitialDelay);

        while (true)
        {
            var bullet = Instantiate(BulletPrefab, gameObject.transform.position - new Vector3(0, 2, 0), Quaternion.identity);
            Destroy(bullet, BulletLifetime);
            yield return new WaitForSeconds(TimeBetweenBullets);
        }
    }
}
