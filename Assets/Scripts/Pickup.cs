using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float Speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        var player = other.transform.root;
        if (player.CompareTag("Player"))
        {
            var points = player.GetComponent<Points>();
            points.Score();

            Destroy(gameObject);
        }
    }
}
