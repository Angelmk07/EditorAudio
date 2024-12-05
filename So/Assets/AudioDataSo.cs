using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Audiodata",menuName ="DataSo")]
public class AudioDataSo : ScriptableObject
{
    [SerializeField] private List<AudioData> sources_1 = new List<AudioData>();
    [SerializeField] private List<AudioData> sources_2 = new List<AudioData>();
    [SerializeField] private List<AudioData> sources_3 = new List<AudioData>();
    [SerializeField] private string id;
    [SerializeField] private string message;
    [SerializeField] private AudioType audioType;
}

[Serializable]
public class AudioData
{
    [SerializeField, Range(0f, 1f)] private float volume;
    [SerializeField] private AudioClip audio;
}
public enum AudioType 
{
    dangerous =0,
    frendly =1,
    middle = 2

}
