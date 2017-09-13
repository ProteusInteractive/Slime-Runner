using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Hex Class defines the grid position, world space position,
/// size, neighbours, etc. of a hex tile. However, it does not
/// interact with Unity directly in any way.
/// </summary>
public class Hex
{
    public Hex(int q, int r)
    {
        this.Q = q;
        this.R = r;
        this.S = -(q + r);
    }

    //Q + R + S = 0
    //S = -(Q + R)

    public readonly int Q; //Column
    public readonly int R; //Row
    public readonly int S;

    static readonly float WIDTH_MULTIPLIER = Mathf.Sqrt(3) / 2;

    /// <summary>
    /// returns world space position of this hex
    /// </summary>
    public Vector3 Position()
    {
        float radius = 1f;
        float height = radius * 2;
        float width = WIDTH_MULTIPLIER * height;

        float horiz = width;
        float vert = height * 0.75f;

        return new Vector3
        (
        horiz * (this.Q + this.R/2f),
        0,
        vert * this.R
        );
    }

}