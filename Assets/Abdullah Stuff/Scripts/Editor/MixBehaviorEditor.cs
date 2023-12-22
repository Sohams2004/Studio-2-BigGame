using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(MixBehaviors))]
public class MixBehaviorEditor : Editor
{

        MixBehaviors selected;


    void OnEnable()
    {
        selected = (MixBehaviors)target;

    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();


        selected = (MixBehaviors)target;



        EditorGUILayout.BeginHorizontal();
        Rect r = EditorGUILayout.BeginHorizontal();
        r.height = EditorGUIUtility.singleLineHeight;
        r.width = EditorGUIUtility.currentViewWidth;

        //mouse position 
        // height of all the text in the window 

        //EditorGUILayout.HelpBox("This is our custom editor!", MessageType.Info);
        //EditorGUILayout.EndHorizontal();
        //EditorGUILayout.LabelField("hello", GUI.skin.verticalSlider);

        //how I can acess variables
        BoidsBehavior[] boidsBehaviors = selected.boidsBehaviors;
        //how I can acess variables with Redo.
        SerializedProperty myBoidsBehaviors = serializedObject.FindProperty("boidsBehaviors");

        if (selected.boidsBehaviors == null || selected.boidsBehaviors.Length == 0)
        {
            EditorGUILayout.EndHorizontal();


            if (GUI.Button(r, "Add Behaviour"))
            {
                //ADD
                AddBehaviour(selected);
                Debug.Log("Pressed Add");
                EditorUtility.SetDirty(selected);
            }

        }
        else
        {

            //how to customize my style ?
            var boldText = new GUIStyle(GUI.skin.label);
            boldText.fontStyle = FontStyle.Bold;

            //padding based on the inspector it stars from the corner top left.
            r.x = 30;
            r.y = 500;
            r.width = EditorGUIUtility.currentViewWidth - 95;
            EditorGUI.LabelField(r, "Behaviour", EditorStyles.boldLabel);
            r.x = EditorGUIUtility.currentViewWidth - 80f;
            EditorGUI.LabelField(r, "Weight", EditorStyles.boldLabel);
            r.y += EditorGUIUtility.singleLineHeight + 10;

            EditorGUI.BeginChangeCheck();
            for (int i = 0; i < selected.boidsBehaviors.Length; i++)
            {
                r.x = 0;
                EditorGUI.LabelField(r, i.ToString());

                r.x = 30;
                r.width = EditorGUIUtility.currentViewWidth - 140f;
                selected.boidsBehaviors[i] = (BoidsBehavior)EditorGUI.ObjectField(r, selected.boidsBehaviors[i], typeof(BoidsBehavior), false);

                r.width = 40;
                r.x = EditorGUIUtility.currentViewWidth - 90f;
                selected.weights[i] = EditorGUI.FloatField(r, selected.weights[i]);
                r.x = 10;
                r.width = 20;

                var mybutton = GUI.Button(r, "-");
                if (mybutton)
                {
                    Debug.Log("Pressed " + i);
                    BoidsBehavior[] newbehaviour = new BoidsBehavior[selected.boidsBehaviors.Length];
                    int[] newWeight = new int[selected.weights.Length];
                    //Remove functionality 

                }
               if (EditorGUI.EndChangeCheck())
                {
                    EditorUtility.SetDirty(selected);

                }
                r.y += EditorGUIUtility.singleLineHeight + 4;


            }
            EditorGUILayout.EndHorizontal();

            r.x = 30f;
            r.width = EditorGUIUtility.currentViewWidth - 160f;
            r.y += EditorGUIUtility.singleLineHeight + 1;

            if (GUI.Button(r, "Add Behaviour"))
            {
                //ADD
                AddBehaviour(selected);
                Debug.Log("Pressed Add");
                EditorUtility.SetDirty(selected);
            }

            r.y += EditorGUIUtility.singleLineHeight + 1;
            if(selected.boidsBehaviors!=null && selected.boidsBehaviors.Length > 0)
            {

                if (GUI.Button(r, "Remove"))
                {
                    RemoveBehaviour(selected);
                    //Remove

                }


            }


        }


    }

    void AddBehaviour(MixBehaviors targeted)
    {
        int oldcount;

        if (targeted.boidsBehaviors == null)
        {
            oldcount = 0;
        }
        else oldcount = targeted.boidsBehaviors.Length;
        BoidsBehavior[] NewList = new BoidsBehavior[oldcount+1];
        float[] newWeight = new float[oldcount+1];

        for (int i=0; i < oldcount; i++)
        {
            NewList[i]= selected.boidsBehaviors[i];
            newWeight[i] = selected.weights[i];
        }
        newWeight[oldcount] = 0f;
        selected.boidsBehaviors= NewList;
        selected.weights= newWeight;

    }
    void RemoveBehaviour(MixBehaviors targeted)
    {
        int oldcount= selected.boidsBehaviors.Length;

        if (oldcount == 1)
        {
            targeted.boidsBehaviors= null;
            targeted.weights= null;
        }
        BoidsBehavior[] NewList = new BoidsBehavior[oldcount - 1];
        float[] newWeight = new float[oldcount - 1];

        for (int i = 0; i < oldcount -1; i++)
        {
            NewList[i] = selected.boidsBehaviors[i];
            newWeight[i] = selected.weights[i];
        }
        selected.boidsBehaviors = NewList;
        selected.weights = newWeight;



    }

}
