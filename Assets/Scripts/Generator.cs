using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private GameObject[] _animalsPrefabs;

    private float rangeXGenerator = 14;
    private float posZGenerator = 15;
    private float sleep = 2.0f;
    private float intervals = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateEnemies", sleep, intervals);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GenerateEnemies()
    {
        //generate animals
        int _indexAnimals = Random.Range(0, _animalsPrefabs.Length);
        Vector3 posGenerator = new Vector3(Random.Range(-rangeXGenerator,
            rangeXGenerator), 0, posZGenerator);

        Instantiate(_animalsPrefabs[_indexAnimals], posGenerator,
            _animalsPrefabs[_indexAnimals].transform.rotation);
    }
}
