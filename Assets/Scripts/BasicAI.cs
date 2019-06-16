using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour
{
    public float aiMovementSpeed = 10f;

    public Transform target;
    public Transform myTransform;

    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    void Update()
    {

        transform.LookAt(target);
        transform.Translate(Vector3.forward * aiMovementSpeed * Time.deltaTime);

    }
}