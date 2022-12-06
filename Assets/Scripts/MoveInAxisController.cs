using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInAxisController : MonoBehaviour
{
    [SerializeField] private float _velocity = 20f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //move food z axis
        transform.Translate(Vector3.down * _velocity * Time.deltaTime);
    }
}
