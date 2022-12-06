using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfScene : MonoBehaviour
{
    [SerializeField] private float _limitZAxisUp = 30;
    [SerializeField] private float _limitZAxisDown = -10;

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        //Destroy Objects out of the scene
        if (transform.position.z > _limitZAxisUp)
        {
            //Destroy(gameObject);

            gameObject.SetActive(false);
        }
        else if (transform.position.z < _limitZAxisDown)
        {
            Destroy(gameObject);
            Debug.Log("GameOver");
        }
    }
}
