using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioScena : MonoBehaviour
{
    [SerializeField] private GameObject _1;
    [SerializeField] private GameObject _2;
    [SerializeField] private GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        _1.SetActive(true);
        cam.SetActive(false);
        _2.SetActive(false);
    }
}