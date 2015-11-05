using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    
    public void NextScene(int index)
    {
        Application.LoadLevel(index);
    }
}

