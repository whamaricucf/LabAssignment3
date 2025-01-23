using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week3Task1 : MonoBehaviour
{
    public string courseName;
    private float challengeScore = 0f;
    private float modulesValue;
    private float readingValue;
    private float quizzesValue;
    private float assignmentsValue;

    [Header("Factors")]
    public int modules;
    public int reading;
    public int quizzes;
    public int assignments;
    public bool prevTaught;

    // Start is called before the first frame update
    void Start()
    {
        modulesValue = ScoreCalc(modules, 15, 15);
        readingValue = ScoreCalc(reading, 30, 15);
        quizzesValue = ScoreCalc(quizzes, 15, 15);
        assignmentsValue = ScoreCalc(assignments, 30, 15);
        challengeScore = modulesValue + readingValue + quizzesValue + assignmentsValue;
        TaughtBefore();
        Debug.Log("The challenge score for " + courseName + " is " + challengeScore + "/10");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float ScoreCalc(float inValue, float percentScore, float maxValue)
    {
        float outValue;
        float calcPercentScore = percentScore/10;
        if(inValue >= maxValue)
        {
            outValue = calcPercentScore;
        }
        else
        {
            outValue = (inValue/maxValue) * calcPercentScore;
        }
        return outValue;
    }

    void TaughtBefore()
    {
        if (!prevTaught)
        {
            challengeScore++;
        }
    }
}
