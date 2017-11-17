using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Hex Class defines the grid positions, world space positions, size, neighbours, etc, of a hex tile.
/// 
/// However, it does not interact with Unity directly in any way.
/// </summary>

public class Hex
{
    // Q + R + S = 0

    public Hex(int q, int r)
    {
        this.Q = q;
        this.R = r;
        this.S = -(q + r);
    }

    public readonly int Q; //column
    public readonly int R; //row
    public readonly int S;

    static readonly float HEIGHT_MULTIPLIER = Mathf.Sqrt(3) / 2;

    /// <summary>
    /// returns the world space position of this hex
    /// </summary>
    public Vector3 Position()
    {
        float radius = 1f;
        float width = radius * 2;
        float height = HEIGHT_MULTIPLIER * width;
        
        float vert = width * 0.75f;
        float horiz = height;

        return new Vector3(vert * this.R, 0, horiz * (this.Q + this.R / 2f));
    }

}
