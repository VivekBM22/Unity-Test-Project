using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    [SerializeField] private int value;
    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.UpdateScore(value);
        Destroy(gameObject);
    }
}