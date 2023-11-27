using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharagedAnimation : MonoBehaviour
{
    public enum ValueType
    {
        isImmediate, isGradual, 

    }
    public Animator animator;
    [Header("Float Only Animation Feedback")]
    public string paramatarName;
    public ValueType AnimationType;
    [SerializeField]ConsoleCharging consoleCharging;

    float newValue=0;
    float timer;
    // Update is called once per frame
    private void Start()
    {


    }

    void Update()
    {
  
        timer-= Time.deltaTime;
        if (timer < 0f) 
        { 

            timer = 0.1f;
            newValue = Mathf.Lerp(newValue, consoleCharging.chargeCounter, 0.2f);

        }

        switch (AnimationType)
        {
            case ValueType.isImmediate:
                animator.SetFloat(paramatarName, consoleCharging.chargeCounter);

                break;

            case ValueType.isGradual:
                animator.SetFloat(paramatarName,newValue);

                break;


        }


    }



}
