using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] GameObject EndStop;
    private float RunSpeed = 0.1f;
    void Start()
    {
        RunSpeed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RunSpeed = RunSpeed * 1.2f;
        }
        transform.position += transform.forward * RunSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider Colliders)
    {
        if (Colliders.CompareTag("Wall"))
        {
            RunSpeed = 0f;
            return;
        }
    }
}
