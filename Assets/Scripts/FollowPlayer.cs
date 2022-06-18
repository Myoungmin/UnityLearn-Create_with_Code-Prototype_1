using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(0, 5, -7);

    // Update is called once per frame
    void LateUpdate()
    {
        // 플레이어 뒤에 카메라를 위치시키기 위한 오프셋
        transform.position = player.transform.position + offset;
    }
}
