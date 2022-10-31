using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveBall : MonoBehaviour
{
    /*[SerializeField] */private Transform _ballTransform;
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private TextMeshProUGUI scoreText;
    private int velocity = 10;

    // Awake is called when the Game Object is loaded
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("Enabled");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started");
        //_ballTransform = GetComponent<Transform>();
        _ballTransform = transform;
    }

    private void OnDisable()
    {
        Debug.Log("Disabled");
    }

    private int i = 0;
    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
        var deltaPos = new Vector3(x, 0, z);
        _ballTransform.position += velocity * deltaPos * Time.deltaTime;

        Debug.Log($"update::{i}");
        i++;
        
        if(ScoreManager.playeHealth <= 0 || _ballTransform.position.y < -30)
        {
            scoreText.SetText(ScoreManager.score.ToString());
            gameOverCanvas.SetActive(true);
        }
    }
}