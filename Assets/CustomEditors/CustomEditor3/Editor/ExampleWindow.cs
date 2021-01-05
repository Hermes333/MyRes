using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ExampleWindow : EditorWindow
{
    Color color;

    string myString = "Hello World !";
    [MenuItem("Window/Colorizer")]
    public static void ShowWindow()
    {
        GetWindow<ExampleWindow>("Colorizer");
    }

    private void OnGUI()
    {
        GUILayout.Label("Color this Selected objects", EditorStyles.label);

        color =  EditorGUILayout.ColorField("Color", color);
        
        if (GUILayout.Button("Colorize!"))
        {
            Colorize();
        }
    }

    void Colorize()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.sharedMaterial.color = color;

            }

        }

    }

}

internal interface IColorize21
{
    void Func2();
    void Func3();
    void Func42();
    void Func5();
}

internal class Colorize2 : MonoBehaviour, IColorize2, IColorize21
{

    public void Func2()
    {


    }
    public void Func3()
    {


    }
    public void Func42()
    {


    }
    public void Func5()
    {


    }
}
