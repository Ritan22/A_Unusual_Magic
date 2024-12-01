using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskLoader : MonoBehaviour
{
    public int taskAdder; 
    // Start is called before the first frame update
    void Start()
    {
        TaskManager.taskManager += taskAdder;
    }
}
