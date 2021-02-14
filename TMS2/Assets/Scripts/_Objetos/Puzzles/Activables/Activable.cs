using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Activable : MonoBehaviour{

    public bool active;

    public abstract void setActive(bool state);
    public abstract void switchState();

    
}
