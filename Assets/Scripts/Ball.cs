using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameObject _trailObject;

    public event Action ThrowEvent;

    void Start()
    {
        _trailObject.SetActive(false);
    }

    public void ActivateTrail()
    {
        _trailObject.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            ThrowEvent?.Invoke();
        }
    }
}
