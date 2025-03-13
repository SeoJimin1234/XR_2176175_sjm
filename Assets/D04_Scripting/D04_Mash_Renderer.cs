using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D04_Mash_Renderer : MonoBehaviour
{

    MeshFilter ThisMeshFilter;

    public GameObject MyCapsule, MySphere;
    // Start is called before the first frame update
    void Start()
    {
        //갖고와서 thismeshfilter에 할당중
        ThisMeshFilter = GetComponent<MeshFilter>();

    }

    // Update is called once per frame
    void Update()
    {
        //pup, down의 차이는 키보드와 같음
        //0: 메인 마우스 버튼
        if(Input.GetMouseButtonDown(0)){
            ThisMeshFilter.mesh = MyCapsule.GetComponent<MeshFilter>().mesh;
        }
        if(Input.GetMouseButtonDown(1)){
            ThisMeshFilter.mesh = MySphere.GetComponent<MeshFilter>().mesh;
        }
    }
}
