#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

[CustomEditor(typeof(EOData))]
public class EOEditor : Editor
{
    private  SerializedProperty m_shortcutData;
    private ReorderableList m_ReorderableList;
    string _ii;

    private void OnEnable()
    {

        m_shortcutData = serializedObject.FindProperty("m_elementlist");


        m_ReorderableList = new ReorderableList(serializedObject: serializedObject, elements: m_shortcutData, draggable: true, displayHeader: true,
            displayAddButton: true, displayRemoveButton: true);


        m_ReorderableList.drawHeaderCallback = DrawHeaderCallback;


        m_ReorderableList.drawElementCallback = DrawElementCallback;


        m_ReorderableList.elementHeightCallback += ElementHeightCallback;


        m_ReorderableList.onAddCallback += OnAddCallback;
    }


    private void DrawHeaderCallback(Rect rect)
    {

        EditorGUI.LabelField(rect, "Element");
    }



    private void DrawElementCallback(Rect rect, int index, bool isactive, bool isfocused)
    {

        SerializedProperty element = m_ReorderableList.serializedProperty.GetArrayElementAtIndex(index);
        rect.y += 2;



        SerializedProperty elementName = element.FindPropertyRelative("m_Name");

        string elementTitle = string.IsNullOrEmpty(elementName.stringValue)
            ? "Element Name"
            : $"_{elementName.stringValue}";

        EditorGUI.PropertyField(position:
            new Rect(rect.x += 10, rect.y, Screen.width * .8f, height: EditorGUIUtility.singleLineHeight), property:
            element, label: new GUIContent(elementTitle), includeChildren: true);
    }


    private float ElementHeightCallback(int index)
    {
        //Gets the height of the element. This also accounts for properties that can be expanded, like structs.
        float propertyHeight =
            EditorGUI.GetPropertyHeight(m_ReorderableList.serializedProperty.GetArrayElementAtIndex(index), true);

        float spacing = EditorGUIUtility.singleLineHeight / 2;

        return propertyHeight + spacing;
    }


    private void OnAddCallback(ReorderableList list)
    {
        //Insert an extra item add the end of our list.
        var index = list.serializedProperty.arraySize;
        list.serializedProperty.arraySize++;
        list.index = index;


        var element = list.serializedProperty.GetArrayElementAtIndex(index);
    }


    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        m_ReorderableList.DoLayoutList();

        serializedObject.ApplyModifiedProperties();
    }
}

#endif
