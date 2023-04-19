//blackbg
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridOverlay : MonoBehaviour
{   
    private Material lineMaterial;

    public bool showMain = true;
    public bool showSub  = true;
    public bool showBG  = true;

    public int gridSizeX;
    public int gridSizeY;

    public float startX;
    public float startY;
    public float startZ;

    public float smallStep;
    public float largeStep;

    public Color mainColor = new Color(15f/255f, 15f/255f, 105f/255f, 1f);
    public Color subColor = new Color(105f/255f, 105f/255f, 105f/255f, 1f);
    public Color bgColor = new Color(0f, 0f, 0f, 1f);

    void CreateLineMaterial (){
        if(!lineMaterial){
            var shader = Shader.Find("Hidden/Internal-Colored");
            lineMaterial = new Material(shader);

            lineMaterial.hideFlags = HideFlags.HideAndDontSave;

            //turn on alpha blending
            lineMaterial.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
            lineMaterial.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);

            //Turn off depth writing
            lineMaterial.SetInt("_ZWrite",0);

            //turn off backface culling
            lineMaterial.SetInt("_Cull", (int)UnityEngine.Rendering.CullMode.Off);
        }
    }

    private void OnDisable(){
        DestroyImmediate(lineMaterial);
    }

    private void OnPostRender() {
        CreateLineMaterial(); // Create the line material
        lineMaterial.SetPass(0);

        // Draw the grid lines
        GL.Begin(GL.LINES);
        if (showSub) {
            GL.Color(subColor);

            for (float y = 0; y <= gridSizeY; y += smallStep) {
                GL.Vertex3(startX, startY + y, startZ);
                GL.Vertex3(startX + gridSizeX, startY + y, startZ);
            }

            for (float x = 0; x <= gridSizeX; x += smallStep) {
                GL.Vertex3(startX + x, startY, startZ);
                GL.Vertex3(startX + x, startY + gridSizeY, startZ);
            }
        }

            if (showMain) {
                GL.Color(mainColor);

                for (float y = 0; y <= gridSizeY; y += largeStep) {
                    GL.Vertex3(startX, startY + y, startZ);
                    GL.Vertex3(startX + gridSizeX, startY + y, startZ);
                }

                for (float x = 0; x <= gridSizeX; x += largeStep) {
                    GL.Vertex3(startX + x, startY, startZ);
                    GL.Vertex3(startX + x, startY + gridSizeY, startZ);
                }
            }

            GL.End();

        // Draw the background
        if (showBG) {
            GL.Begin(GL.QUADS);
            GL.Color(bgColor);

            GL.Vertex3(startX, startY, startZ - 1);
            GL.Vertex3(startX + gridSizeX, startY, startZ - 1);
            GL.Vertex3(startX + gridSizeX, startY + gridSizeY, startZ - 1);
            GL.Vertex3(startX, startY + gridSizeY, startZ - 1);

            GL.End();
        }
    }
}








// //simple

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class GridOverlay : MonoBehaviour
// {   
//     private Material lineMaterial;

//     public bool showSub = true;
//     public bool showBG = true;
//     public bool showMain = true;

//     public int gridSizeX;
//     public int gridSizeY;

//     public float startX;
//     public float startY;
//     public float startZ;

//     public float smallStep;
//     public float largeStep;

//     public Color mainColor = new Color(15f, 15f, 105f, 255f);
//     public Color subColor = new Color(105f, 105f, 105f, 255f);
//     public Color bgColor = new Color(0f, 0f, 0f, 255f);

//     private void CreateLineMaterial()
//     {
//         if (!lineMaterial)
//         {
//             var shader = Shader.Find("Hidden/Internal-Colored");
//             lineMaterial = new Material(shader);

//             lineMaterial.hideFlags = HideFlags.HideAndDontSave;

//             // Turn on alpha blending
//             lineMaterial.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
//             lineMaterial.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);

//             // Turn off depth writing
//             lineMaterial.SetInt("_ZWrite", 0);

//             // Turn off backface culling
//             lineMaterial.SetInt("_Cull", (int)UnityEngine.Rendering.CullMode.Off);
//         }
//     }

//     private void OnDisable()
//     {
//         DestroyImmediate(lineMaterial);
//     }

//     private void OnPostRender()
//     {
//         CreateLineMaterial(); // Create the line material
//         lineMaterial.SetPass(0);

//         // Draw the grid lines
//         GL.Begin(GL.LINES);
//         if (showSub)
//         {
//             GL.Color(subColor);

//             for (float y = 0; y <= gridSizeY; y += smallStep)
//             {
//                 GL.Vertex3(startX, startY + y, startZ);
//                 GL.Vertex3(startX + gridSizeX, startY + y, startZ);
//             }

//             for (float x = 0; x <= gridSizeX; x += smallStep)
//             {
//                 GL.Vertex3(startX + x, startY, startZ);
//                 GL.Vertex3(startX + x, startY + gridSizeY, startZ);
//             }
//         }

//         GL.Begin(GL.QUADS);
//         if (showBG)
//         {
//             GL.Color(Color.black);
//             GL.Vertex3(startX, startY, startZ - 1);
//             GL.Vertex3(startX + gridSizeX, startY, startZ - 1);
//             GL.Vertex3(startX + gridSizeX, startY + gridSizeY, startZ - 1);
//             GL.Vertex3(startX, startY + gridSizeY, startZ - 1);
//         }

//         GL.End();

//         if (showMain)
//         {
//             GL.Begin(GL.LINES);
//             GL.Color(mainColor);

//             for (float y = 0; y <= gridSizeY; y += largeStep)
//             {
//                 GL.Vertex3(startX, startY + y, startZ);
//                 GL.Vertex3(startX + gridSizeX, startY + y, startZ);
//             }

//             for (float x = 0; x <= gridSizeX; x += largeStep)
//             {
//                 GL.Vertex3(startX + x, startY, startZ);
//                 GL.Vertex3(startX + x, startY + gridSizeY, startZ);
//             }

//             GL.End();
//         }
//     }
// }
