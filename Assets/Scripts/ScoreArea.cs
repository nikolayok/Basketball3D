using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    [SerializeField] private GameObject effectObject;

    private void Start()
    {
        effectObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Ball>() != null)
        {
            effectObject.SetActive(true);
        }
    }
}
