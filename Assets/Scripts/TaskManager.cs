using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public static int taskManager;
    public GameObject canva;
    public GameObject player;
    public GameObject newCamera;
    // Start is called before the first frame update
    void Start()
    {
        taskManager = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Dialogues.canva == true){
            newCamera.SetActive(true);
            newCamera.transform.localPosition = player.transform.localPosition;
            player.SetActive(false);
            canva.SetActive(true);
        }else{
            canva.SetActive(false);
            player.SetActive(true);
            newCamera.SetActive(false);
        }
        if (taskManager == 4){}
        if (taskManager == 9){}
        if (taskManager == 10){}
        if (taskManager == 11){}
        if (taskManager == 12){}
        if (taskManager == 13){}
        if (taskManager == 14){}
        if (taskManager == 15){}
        if (taskManager == 16){}
        if (taskManager == 17){}
        print(taskManager);
    }
}
