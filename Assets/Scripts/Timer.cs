using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float time;
    [SerializeField] TextMeshProUGUI timerText;
    // asta e un timer, sper sa mearga, oricum ruleaza doar o data deci ar trebui sa fie ok
    void Start()
    {
        StartCoroutine("Time");
        timerText.text = time.ToString();
    }

    IEnumerator Time()
    {
        while(time>0f)
        {
            time -= 0.01f;
            yield return new WaitForSeconds(0.01f);
            timerText.text = time.ToString("F2");
        }
    }
}
