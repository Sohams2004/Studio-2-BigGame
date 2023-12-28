using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static Codice.Client.BaseCommands.Import.Commit;


[CustomEditor(typeof(MixBehaviors))]
public class MixBehaviorEditor : Editor
{
    SerializedProperty myBoidsBehaviors;
        MixBehaviors selected;

    void OnEnable()
    {
        selected = (MixBehaviors)target;

    }
    public override void OnInspectorGUI()
    {
        selected = (MixBehaviors)target;

        GUILayout.BeginHorizontal();    

          BoidsBehavior[] boidsBehaviors = selected.boidsBehaviors;
        //how I can acess variables with Redo.

        if (selected.boidsBehaviors == null || selected.boidsBehaviors.Length == 0)
        {
            GUILayout.EndHorizontal();


            if (GUILayout.Button( "Add Behaviour"))
            {
                //ADD
                AddBehaviour(selected);
                Debug.Log("Pressed Add");
            }

        }
        else
        {
            serializedObject.Update();
            GUILayout.Label("Behaviour", EditorStyles.boldLabel);
            GUILayout.Label("Weight", EditorStyles.boldLabel, GUILayout.Width(50f));
            GUILayout.EndHorizontal();
            for (int i = 0; i < selected.boidsBehaviors.Length; i++)
            {
                var MySkin = new GUIStyle(GUI.skin.button);
                GUILayout.BeginHorizontal();
                if (GUILayout.Button("-", MySkin, GUILayout.Width(14f), GUILayout.Height(14f)))
                {

                    Debug.Log("CLICKED"+i);
                    RemoveBehaviour(selected,i);

                }
                selected.boidsBehaviors[i] = (BoidsBehavior)EditorGUILayout.ObjectField("", selected.boidsBehaviors[i], typeof(BoidsBehavior), false, GUILayout.Width(100f));
                GUILayout.Label("-50", EditorStyles.boldLabel, GUILayout.Width(25f));
                selected.weights[i]=GUILayout.HorizontalSlider(selected.weights[i], -50, 50);
                GUILayout.Label("50", EditorStyles.boldLabel, GUILayout.Width(20f));
                float newValue = selected.weights[i];
                newValue = EditorGUILayout.FloatField(selected.weights[i],GUILayout.Width(25f));
                selected.weights[i] = newValue;

                GUILayout.EndHorizontal();
            }


            if (GUILayout.Button( "Add Behaviour"))
            {
                //ADD
                AddBehaviour(selected);
                Debug.Log("Pressed Add");
                EditorUtility.SetDirty(selected);
            }

            if(selected.boidsBehaviors!=null && selected.boidsBehaviors.Length > 0)
            {

                if (GUILayout.Button("Remove"))
                {
                    RemoveBehaviour(selected, selected.weights.Length);
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
    void RemoveBehaviour(MixBehaviors targeted, int number)
    {

        if (selected.weights.Length == 1)
        {
            targeted.boidsBehaviors= null;
            targeted.weights= null;
            return;
        }
        BoidsBehavior[] NewList = new BoidsBehavior[selected.weights.Length - 1];
        float[] newWeight = new float[selected.weights.Length - 1];

        for (int i = 0; i < selected.weights.Length-1f; i++)
        {
            int count = 0;
            if (number == i)
            {
                count= count -1;
                continue;
            }

            NewList[i+count] = selected.boidsBehaviors[i];
            newWeight[i+count] = selected.weights[i];
        }
        selected.boidsBehaviors = NewList;
        selected.weights = newWeight;



    }

}
