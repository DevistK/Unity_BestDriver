using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
    private float steerSpeed = 300;

    // 유니티 inspactor 에서 프로젝트를 실행 시켰을때 변수값을 실시간으로 전달할 수 있음.
    [SerializeField]
    private float moveSpeed = 20;

    void Start() { }

    void Update()
    {
        // Update 가 매 프레임마다 호출되고 있어도 아무 움직임이 없는 이유는 키보드 Input값을 전달받는데 아무입력이 없으면 0에 도달하기 때문에 원하는 플레이가 가능
        // 단 수평조작은 음수로 계산되어야 좌 , 우 방향을 올바르게 맞춰줄 수 있음. -1 음수로 가까울수록 왼쪽으로 가기 때문에 , 반대 방향으로 가지 않으려면 음수 처리 해줘야함
        // Time.deltaTime은 매 프레임 이전 값으로 동적인 값이 증감 할때 곱해주어 일정한 독립적인 프레임 값을 만들어준다.

        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
