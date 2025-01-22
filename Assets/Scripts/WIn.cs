using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIn : MonoBehaviour
{
    [SerializeField] GameObject _1;
    [SerializeField] GameObject _2;
    [SerializeField] GameObject _3;
    [SerializeField] GameObject _4;
    [SerializeField] GameObject _5;
    [SerializeField] GameObject _6;
    [SerializeField] GameObject _7;
    [SerializeField] GameObject _8;
    [SerializeField] GameObject _9;
    [SerializeField] GameObject _10;
    [SerializeField] GameObject _11;
    [SerializeField] GameObject _12;
    [SerializeField] GameObject _13;
    [SerializeField] GameObject _14;
    [SerializeField] GameObject _15;
    [SerializeField] GameObject _16;
    [SerializeField] GameObject self;
    [SerializeField] GameObject player;
    [SerializeField] GameObject cameraEffetto;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (_1.activeSelf && _2.activeSelf && _3.activeSelf && _4.activeSelf && _5.activeSelf && _6.activeSelf &&
        _7.activeSelf && _8.activeSelf && _9.activeSelf && _10.activeSelf && _11.activeSelf && _12.activeSelf && _13.activeSelf && _14.activeSelf && _15.activeSelf && _16.activeSelf)
        {
            print("Yout win");
            
            //player.SetActive(true);
            //cameraEffetto.SetActive(false);
            TaskManager.minigioco = true;
            Destroy(self);
        }if (Input.GetKeyDown(KeyCode.Escape)){
            player.SetActive(true);
            cameraEffetto.SetActive(false);
            Destroy(self);

        }
    }
}
