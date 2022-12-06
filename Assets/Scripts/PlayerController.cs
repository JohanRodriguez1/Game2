using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 20f;
    [SerializeField] private float _xRange = 20;
    [SerializeField] private GameObject _food;
    //[SerializeField] private GameObject _bottle;

    private float _moveHorizontal;
    private Vector3 _offset = new Vector3 (-1.6f,1.8f,0.6f);
    //private Vector3 _offset2 = new Vector3 (1.6f,1.95f,0.26f);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //throw food or bottles
        if (Input.GetKeyDown(KeyCode.G))
        {
            //Instantiate(_food, transform.position + _offset, _food.transform.rotation);

            GameObject pooledProjectile = ObjectPooler.SharedInstance.GetPooledObject();
            if (pooledProjectile != null)
            {
                pooledProjectile.SetActive(true);
                pooledProjectile.transform.position = transform.position + _offset;
            }
        }
        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    Instantiate(_bottle, transform.position + _offset2, _bottle.transform.rotation);
        //}

        //keep the limits of the player in left/right sides
        if (transform.position.x < -_xRange)
        {
            transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > _xRange)
        {
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
        }

        _moveHorizontal = Input.GetAxis("Horizontal");
        //move player axis x
        transform.Translate(Vector3.right * _moveHorizontal * _speed * Time.deltaTime);
    }
}
