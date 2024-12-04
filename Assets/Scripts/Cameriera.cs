using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameriera : MonoBehaviour
{
    [SerializeField] private GameObject piangente1;
    [SerializeField] private GameObject piangente;
    // Start is called before the first frame update
    void Start()
    {
        piangente1.SetActive(true);
        piangente.SetActive(false);
    }
}
