using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Stickable
{
    // inheriting food will use : Grillable, and include public override void Grill.
    void Stick(GameObject stickChild);
}