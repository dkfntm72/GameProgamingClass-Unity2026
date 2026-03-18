using UnityEngine;

public class RoulettController : MonoBehaviour
{
    float rotSpeed = 0; // 회전속도
    void Start()
    {
        Application.targetFrameRate = 60;// 프레임 최대값 지정
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= 0.96f;
    }
}
