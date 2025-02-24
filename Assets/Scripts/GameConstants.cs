using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConstants : MonoBehaviour
{
    /* The Levels enum denotes the various levels available to the Player.
     * Levels should be named after their respective Scene names.
     */
    public enum Levels {
        Level1,
        Level2,
        Level3,
        Tutorial1,
        Tutorial2,
        Tutorial3
    }
    
    /*
     * Types of Paints Nox can carry
     */
    public enum Paints {
        Yellow, Red, Green, Blue
    }
    
    /*
     * The Colors of the Paints Nox can carry
     */
    public static readonly Color32 Red = new Color32(241, 95, 62, 255);
    public static readonly Color32 Green = new Color32(166, 191, 75, 255);
    public static readonly Color32 Yellow = new Color32(242, 191, 61, 255);
    public static readonly Color32 Blue = new Color32(140, 210, 205, 255);

    /*
     * The Colors of emissions produced by various materials
     */
    public static readonly Color32 RedEmission = new Color32(255, 0, 32, 255);
    public static readonly Color32 GreenEmission = new Color32(114, 255, 45, 255);
    public static readonly Color32 YellowEmission = new Color32(200, 130, 0, 255);
    public static readonly Color32 BlueEmission = new Color32(0, 255, 187, 255);

    /*
     * Dict colorsToEmissions binds Color32 values of paint colors
     * to their respective emission colors on materials
     */
    public static readonly Dictionary<Color32, Color32> colorsToEmissions =
                       new Dictionary<Color32, Color32>()
    {
        [Red] = RedEmission,
        [Green] = GreenEmission,
        [Yellow] = YellowEmission,
        [Blue] = BlueEmission
    };

    /*
     * World interaction visual feedback constants
     */
    public const float HOVEROVER_R = 1f;
    public const float HOVEROVER_G = 1f;
    public const float HOVEROVER_B = 0f;
    
    public const float SELECTION_R = 0.1f;
    public const float SELECTION_G = 0.1f;
    public const float SELECTION_B = 0.1f;
    public const float SELECTION_LIGHT_R = 1f;
    public const float SELECTION_LIGHT_G = 1f;
    public const float SELECTION_LIGHT_B = 1f;
    
    public const float UNINTERACTABLE_SELECTION_R = 1f;
    public const float UNINTERACTABLE_SELECTION_G = 0.2f;
    public const float UNINTERACTABLE_SELECTION_B = 0f;

    /*
     * Note this is for the switch paint UI but they're not pointing in the right direction.
     * Everything seems to be rotated, but still works. Just need to rename later.
     */
    public const string NorthwestQuadrant = "NW";
    public const string NortheastQuadrant = "NE";
    public const string SouthwestQuadrant = "SW";
    public const string SoutheastQuadrant = "SE";

    /*
     * Used to determine which way to invert Player movement
     * since the camera rotates at 90-degree intervals.
     * Default camera placement should always be considered N
     */
    public enum CameraDirection
    {
        None, N, E, S, W
    }

     /*
     * Representations of the directions the Player can face.
     * Should align up with `GameConstants.CameraDirection`.
     */
    public enum PlayerDirection
    {
        None, Forward, Right, Backward, Left
    }

    public const float PlayerHeight = 1.766f;
}
