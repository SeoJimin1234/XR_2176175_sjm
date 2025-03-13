using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MonoBehaviour을 상속받는 클래스의 이름은 파일과 이름이 같아야 함
//scnene의 컴포넌트로 등장시켜야 함
//소문자 transform
public class D04_Scripting : MonoBehaviour
{
    // Start is called before the first frame update
    // 실행할때 딱 한번
    void Start()
    {
        print("hello world");
        //이 스크립트가 부착되어있는 그 오브젝트의 이름
        Debug.Log(gameObject.name);
    }

    // Update is called once per frame
    //start가 실행된 이후에는 update안의 스크립트가 실행됨
    void Update()
    {
        //getkey: 키보드를 누르고 있는 동안, dowm: 쭉 눌러도 하나로, up꾹 누르다가 끝날때
        // translate: 위치 값 조정
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,0,1.5f);//x,y,z, 축
        }
        //getkey: 키보드를 누르고 있는 동안, dowm: 쭉 눌러도 하나로, up꾹 누르다가 끝날때
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0,0,-1.5f);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(0,-1,0); //도는 양 단위: de
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(0,1,0); //도는 양 단위: de
        }
    }
}
