using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    //[SerializeField] private TextMeshProUGUI inputScore; //int.Parse(inputScore.text)
    [SerializeField] private TMP_InputField inputName;
    [SerializeField] private TMP_InputField inputScore;

    public UnityEvent<string, int> submitScoreEvent;
    public void SubmitScore()
    {
        submitScoreEvent.Invoke(inputName.text, int.Parse(inputScore.text));
    }
}
