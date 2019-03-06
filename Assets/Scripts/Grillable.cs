﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Grillable
{
    // inheriting food will use : Grillable, and include public override void Grill.
    void Grill();
    void Stop();
}