using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(order = 0, fileName = "Level", menuName = "Create Level Data")]
public class LevelData : ScriptableObject
{
    public GameObject levelPrefab;
}