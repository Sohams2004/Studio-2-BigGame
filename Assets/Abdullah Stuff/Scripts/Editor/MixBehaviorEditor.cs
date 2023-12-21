using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static Codice.Client.BaseCommands.Import.Commit;


[CustomEditor(typeof(MixBehaviors))]
public class MixBehaviorEditor : Editor
{

        MixBehaviors selected;


    public override void OnInspectorGUI()
    {
        selected = (MixBehaviors)target;
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

        if (selected.boidsBehaviors==null || selected.boidsBehaviors.Length == 0)
        {
            EditorGUILayout.EndHorizontal();

            DrawDefaultInspector();

            EditorGUILayout.HelpBox("No Behaviours are listed", MessageType.Warning);
            
        }
        else
        {
            //how to customize my style ?
            var boldText = new GUIStyle(GUI.skin.label);
            boldText.fontStyle = FontStyle.Bold;

            //padding based on the inspector it stars from the corner top left.
            r.x = 30;
            r.y = 10;
            
            r.width = EditorGUIUtility.currentViewWidth-95;
            EditorGUI.LabelField(r, "Behaviour", EditorStyles.boldLabel);
            r.x = EditorGUIUtility.currentViewWidth - 80f;
            EditorGUI.LabelField(r, "Weight", EditorStyles.boldLabel);
            r.y += EditorGUIUtility.singleLineHeight + 10;

            for (int i=0; i< selected.boidsBehaviors.Length; i++)
            {
                r.x = 0;
                EditorGUI.LabelField (r, i.ToString());

                r.x = 30;
                r.width = EditorGUIUtility.currentViewWidth - 140f;
                selected.boidsBehaviors[i]=(BoidsBehavior)EditorGUI.ObjectField(r, selected.boidsBehaviors[i], typeof(BoidsBehavior), false);

                r.width = 40;
                r.x = EditorGUIUtility.currentViewWidth - 90f;
                selected.weights[i] = EditorGUI.FloatField(r, selected.weights[i]);
                r.x = 10;
                r.width = 20;

                var mybutton = GUI.Button(r, "-");
                if (mybutton)
                {
                    Debug.Log("Pressed " + i);
                    BoidsBehavior[] newbehaviour= new BoidsBehavior[selected.boidsBehaviors.Length];
                    int[] newWeight= new int[selected.weights.Length];
                    //Remove 

                }

                r.y += EditorGUIUtility.singleLineHeight + 4;


            }
            EditorGUILayout.EndHorizontal();
            r.x = 30f;
            r.width = EditorGUIUtility.currentViewWidth - 160f;

            r.y += EditorGUIUtility.singleLineHeight + 1;
            if (GUI.Button(r,"Add Behaviour"))
            {
                Debug.Log("Pressed Add");

                //ADD

            }



        }


    }



}
