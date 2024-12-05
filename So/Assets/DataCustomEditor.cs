using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(AudioDataSo))]
public class DataCustomEditor : Editor
{
    private SerializedProperty _idProp;
    private SerializedProperty _messageProp;
    private SerializedProperty _audio;
    private SerializedProperty sources_1;
    private SerializedProperty sources_2;
    private SerializedProperty sources_3;
    private bool _isMassege;
    private List<AudioClip> _clips;

    private void Awake()
    {
        _idProp = serializedObject.FindProperty("id");
        _messageProp = serializedObject.FindProperty("message");
        _audio = serializedObject.FindProperty("audioType");
        sources_1 = serializedObject.FindProperty("sources_1");
        sources_2 = serializedObject.FindProperty("sources_2");
        sources_3 = serializedObject.FindProperty("sources_3");

    }
    public override void OnInspectorGUI()
    {
        AudioDataSo audioData = (AudioDataSo)target;

        #region
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Meesage"))
        {
            _isMassege = true;
        }
        if (GUILayout.Button("Hide"))
        {
            _isMassege = false;
        }
        EditorGUILayout.EndHorizontal();
        #endregion
        EditorGUILayout.PropertyField(_idProp);
        EditorGUILayout.PropertyField(_audio);
        switch (_audio.enumValueIndex) 
        {
            case 0:
                EditorGUILayout.PropertyField(sources_1);
                break;
            case 1:
                EditorGUILayout.PropertyField(sources_2);
                break;
            case 2:
                EditorGUILayout.PropertyField(sources_3);
                break;


        }


        DrowMassage();
        serializedObject.ApplyModifiedProperties();
    }

    private void DrowMassage()
    {
        if (_isMassege)
        {
            EditorGUILayout.PropertyField(_messageProp);
        }
    }
}