using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 플레이어 뒤에 카메라를 위치시키기 위한 오프셋
        transform.position = player.transform.position + new Vector3(0, 5, -7);
    }
}
