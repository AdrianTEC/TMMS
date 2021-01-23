﻿using System.Collections.Generic;
using _Scripts.TaskSystem.Tasks;
using TMPro;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    
    public TextMeshProUGUI tituloMesh;
    public TextMeshProUGUI DefinitionMesh;
    public List<GameTask> tareas;

    public GameTask currentTask;

    private void Start()
    {
        Next();
    }

    public void Next()
    {
        Debug.Log("siguienteTarea");
        currentTask = tareas[0];
        tareas.RemoveAt(0);
        Visualize();
    }

    public void AddNew(GameTask tarea)
    {
        tareas.Add(tarea);
        Next();
    }
    public void Visualize()
    {
        if(currentTask==null) return;
        tituloMesh.text = currentTask.taskName;
        DefinitionMesh.text = currentTask.definition;
    }
    
}