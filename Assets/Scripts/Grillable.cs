using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Grillable : MonoBehaviour
{
    // inheriting food will use : Grillable, and include public override void Grill.
    public abstract void Grill();
}
