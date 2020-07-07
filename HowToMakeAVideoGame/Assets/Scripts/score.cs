using System;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Transform endPosition;
    public Text scoreText;
    int maxScore;
    void Start()
    {
        maxScore = Convert.ToInt32(endPosition.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = (maxScore-endPosition.position.z).ToString("0");
    }
}
