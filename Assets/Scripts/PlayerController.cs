using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //We'll move the vehicle forward
        //Time.deltaTime을 이용하여 차량의 이동속도를 보정
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
