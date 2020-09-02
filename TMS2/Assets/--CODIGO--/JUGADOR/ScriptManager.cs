﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ScriptManager : MonoBehaviour
{   

    public Movimiento movimiento;
    public Vida vida;
    public TAMANO barra;
    public ModoBOT bot;
    public NavMeshAgent nav;
    public Inventario inv;
    public Apuntado apuntado;
    void Start()
        {
                movimiento=gameObject.GetComponent<Movimiento>();
                nav=gameObject.GetComponent<NavMeshAgent>();
                inv=gameObject.GetComponent<Inventario>();
                bot=gameObject.GetComponent<ModoBOT>();
                vida=gameObject.GetComponent<Vida>();
                barra=vida.estatus.transform.GetChild(0).gameObject.GetComponent<TAMANO>();
                apuntado= gameObject.transform.GetChild(2).gameObject.GetComponent<Apuntado>();
        }
    public void setToBot()
        {
            movimiento.enabled=false;
            nav.enabled=true;
            inv.enabled=false;
            bot.enabled=true;
            barra.ToBack();
        }
    public void establecerCompanero(GameObject target)
        {
            bot.companero=target;
        }
    
    public void setToPlayer()
        {
            movimiento.enabled=true;
            nav.enabled=false;
            inv.enabled=true;
            bot.enabled=false;
            barra.ToFront();
        }

}
