using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private TextMeshProUGUI textObject;


    void Awake()
    {
        textObject.text = score.ToString();
    }

    void Start()
    {
        ScoreBehaviour.onCollissionEntered += ScoreUpdate;
    }

    void Update()
    {

    }

    void ScoreUpdate()
    {
        ++score;
        textObject.text = score.ToString();
    }

    void OnDisable()
    {
        ScoreBehaviour.onCollissionEntered -= ScoreUpdate;
    }
}
