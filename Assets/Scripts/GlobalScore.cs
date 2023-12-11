using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public GameObject ScoreBox;
    public static int currentScore;
    public int InternalScore;

    void Update()
    {
        InternalScore = currentScore;
        ScoreBox.GetComponent<Text>().text = "" + InternalScore;
    }
}
