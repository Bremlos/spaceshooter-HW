using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMissile : MonoBehaviour {

    [Range(100, 1000)]
    public float speed = 100;

     void Start()
    {
       transform.rotation = transform.localRotation;
    }

    void Update ()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
	}
}
