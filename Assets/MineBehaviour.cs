using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineBehaviour : MonoBehaviour
{
    [SerializeField] private int damage;

    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.UpdateHealth(-damage);
        Destroy(gameObject);
    }
}