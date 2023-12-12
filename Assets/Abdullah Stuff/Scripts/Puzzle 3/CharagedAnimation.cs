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
    public float animationDelay = 0.02f;

    // Update is called once per frame
    private void Start()
    {


    }

    void Update()
    {
        float currentAnimation = animator.GetFloat(paramatarName);
        timer -= Time.deltaTime;
        if (timer < animationDelay) 
        { 

            timer = 0.02f;
            newValue = Mathf.Lerp(newValue, consoleCharging.chargeCounter, animationDelay);

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
