using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

[CreateAssetMenu(order = 0, fileName = "Element", menuName = "ScriptableObjects/SpawnManagerScriptableObject")]
public class EOData : ScriptableObject
{   

    public string AB_TestValue = "";
    
    public  List<ShortcutDataRecord2> m_elementlist;
    [System.Serializable]
    public class ShortcutDataRecord2
    {
        [SerializeField]
        private string m_Name;

        public GameObject m_carprefab;
        public int m_carindex;
        public float price;
        public Sprite front_image;
        public float power, brake, suspension;

        public int upgrdIndex;
        public float[] upgrdPowerArray;
        public float[] upgrdBrakeArray;
        public float[] upgrdSuspensionArray;

        public float[] PRICEupgradeArray;


        public bool is_purchased;
        public bool is_activecar;
        public bool is_testing;

        public string name => m_Name;

        

    }



}