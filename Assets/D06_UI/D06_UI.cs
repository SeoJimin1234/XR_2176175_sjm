using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D06_UI : MonoBehaviour
{
    public void OnClick_Distroy(GameObject Target){
        Destroy(Target);

    }

    public void Onclick_loadScene(){
        SceneManager.loadScene(0);
    }
}
