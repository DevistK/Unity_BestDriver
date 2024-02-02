using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        // OnCollisionEnter 내장 메서드를 사용해서 Rigid Body와 Collider 가 적용된 물리 객체에 충돌 이벤트를 만들어줄 수 있다.
        // 2D 는 스프라이트 전용 , 2D 가 안붙어 있으면 3D 전용
        Debug.Log($"Crush !!");
    }
}
