using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject cubePrefab;
    private List<GameObject> cubeList = new List<GameObject>();
    private List<Zuobiao> zuobiaoList = new List<Zuobiao>();

    Vector3 position;
    Vector3 scale;

    int x;
    int y;
    int z;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    switch (i)
                    {
                        case 0:
                            x = 8;
                            break;
                        case 1: 
                            x = 19;
                            break;
                        case 2:
                            x = 30;
                            break;
                        default:
                            break;
                    }
                    switch (j)
                    {
                        case 0:
                            y = 12;
                            break;
                        case 1:
                            y = 19;
                            break;
                        case 2:
                            y = 26;
                            break;
                        default:
                            break;
                    }
                    switch (k)
                    {
                        case 0:
                            z = 16;
                            break;
                        case 1:
                            z = 19;
                            break;
                        case 2:
                            z = 22;
                            break;
                        default:
                            break;
                    }
                    GouZaoMofang(x, y, z,i,j,k);
                }
            }
        }
        //Vector3 position = new Vector3((19 + 8) / 2f, (19 + 12) / 2f, (19 + 16) / 2f);
        //Vector3 scale = new Vector3(8, 12, 16);
        //GameObject cube = Instantiate(cubePrefab, position,transform.rotation);
        //cube.transform.localScale=scale;
        //Zuobiao zb= cube.GetComponent<Zuobiao>();
        //zb.X = 1;

    }

    private void OnGUI()
    {
        if (GUILayout.Button("F面旋转"))
        {
            RotateF();
        }
        if (GUILayout.Button("u面旋转"))
        {
            RotateU();
        }
        if (GUILayout.Button("R面旋转"))
        {
            RotateR();
        }
    }

    private void RotateF()
    {
        for (int i = 0; i < 27; i++)
        {
            if (zuobiaoList[i].Z==0)
            {
                cubeList[i].transform.RotateAround( Vector3.zero,Vector3.back, 90);
                if (zuobiaoList[i].X==0&& zuobiaoList[i].Y == 0)
                {
                    zuobiaoList[i].X = 0;
                    zuobiaoList[i].Y = 2;
                }
                else if (zuobiaoList[i].X == 0 && zuobiaoList[i].Y == 1)
                {
                    zuobiaoList[i].X = 1;
                    zuobiaoList[i].Y = 2;
                }
                else if (zuobiaoList[i].X == 0 && zuobiaoList[i].Y == 2)
                {
                    zuobiaoList[i].X = 2;
                    zuobiaoList[i].Y = 2;
                }
                else if (zuobiaoList[i].X == 1 && zuobiaoList[i].Y == 2)
                {
                    zuobiaoList[i].X = 2;
                    zuobiaoList[i].Y = 1;
                }
                else if (zuobiaoList[i].X == 2 && zuobiaoList[i].Y == 2)
                {
                    zuobiaoList[i].X = 2;
                    zuobiaoList[i].Y = 0;
                }
                else if (zuobiaoList[i].X == 2 && zuobiaoList[i].Y == 1)
                {
                    zuobiaoList[i].X = 1;
                    zuobiaoList[i].Y = 0;
                }
                else if (zuobiaoList[i].X == 2 && zuobiaoList[i].Y == 0)
                {
                    zuobiaoList[i].X = 0;
                    zuobiaoList[i].Y = 0;
                }
                else if (zuobiaoList[i].X == 1 && zuobiaoList[i].Y == 0)
                {
                    zuobiaoList[i].X = 0;
                    zuobiaoList[i].Y = 1;
                }
            }
        }

    }

    private void RotateU()
    {
        for (int i = 0; i < 27; i++)
        {
            if (zuobiaoList[i].Y == 2)
            {
                cubeList[i].transform.RotateAround(Vector3.zero, Vector3.up, 90);
                if (zuobiaoList[i].X == 0 && zuobiaoList[i].Z == 0)
                {
                    zuobiaoList[i].X = 0;
                    zuobiaoList[i].Z = 2;
                }
                else if (zuobiaoList[i].X == 0 && zuobiaoList[i].Z == 1)
                {
                    zuobiaoList[i].X = 1;
                    zuobiaoList[i].Z = 2;
                }
                else if (zuobiaoList[i].X == 0 && zuobiaoList[i].Z == 2)
                {
                    zuobiaoList[i].X = 2;
                    zuobiaoList[i].Z = 2;
                }
                else if (zuobiaoList[i].X == 1 && zuobiaoList[i].Z == 2)
                {
                    zuobiaoList[i].X = 2;
                    zuobiaoList[i].Z = 1;
                }
                else if (zuobiaoList[i].X == 2 && zuobiaoList[i].Z == 2)
                {
                    zuobiaoList[i].X = 2;
                    zuobiaoList[i].Z = 0;
                }
                else if (zuobiaoList[i].X == 2 && zuobiaoList[i].Z == 1)
                {
                    zuobiaoList[i].X = 1;
                    zuobiaoList[i].Z = 0;
                }
                else if (zuobiaoList[i].X == 2 && zuobiaoList[i].Z == 0)
                {
                    zuobiaoList[i].X = 0;
                    zuobiaoList[i].Z = 0;
                }
                else if (zuobiaoList[i].X == 1 && zuobiaoList[i].Z == 0)
                {
                    zuobiaoList[i].X = 0;
                    zuobiaoList[i].Z = 1;
                }
            }
        }
    }

    private void RotateR()
    {
        for (int i = 0; i < 27; i++)
        {
            if (zuobiaoList[i].X == 2)
            {
                cubeList[i].transform.RotateAround(Vector3.zero, Vector3.right, 90);
                if (zuobiaoList[i].Z == 0 && zuobiaoList[i].Y == 0)
                {
                    zuobiaoList[i].Z = 0;
                    zuobiaoList[i].Y = 2;
                }
                else if (zuobiaoList[i].Z == 0 && zuobiaoList[i].Y == 1)
                {
                    zuobiaoList[i].Z = 1;
                    zuobiaoList[i].Y = 2;
                }
                else if (zuobiaoList[i].Z == 0 && zuobiaoList[i].Y == 2)
                {
                    zuobiaoList[i].Z = 2;
                    zuobiaoList[i].Y = 2;
                }
                else if (zuobiaoList[i].Z == 1 && zuobiaoList[i].Y == 2)
                {
                    zuobiaoList[i].Z = 2;
                    zuobiaoList[i].Y = 1;
                }
                else if (zuobiaoList[i].Z == 2 && zuobiaoList[i].Y == 2)
                {
                    zuobiaoList[i].Z = 2;
                    zuobiaoList[i].Y = 0;
                }
                else if (zuobiaoList[i].Z == 2 && zuobiaoList[i].Y == 1)
                {
                    zuobiaoList[i].Z = 1;
                    zuobiaoList[i].Y = 0;
                }
                else if (zuobiaoList[i].Z == 2 && zuobiaoList[i].Y == 0)
                {
                    zuobiaoList[i].Z = 0;
                    zuobiaoList[i].Y = 0;
                }
                else if (zuobiaoList[i].Z == 1 && zuobiaoList[i].Y == 0)
                {
                    zuobiaoList[i].Z = 0;
                    zuobiaoList[i].Y = 1;
                }
            }
        }
    }

   
    void GouZaoMofang(int x,int y,int z, int i, int j, int k)
    {
        float xp, yp, zp;
        if (x == 8)
        {
            xp = -(x + 19) / 2f;
        }else if (x == 19)
        {
            xp = 0;
        }
        else
        {
            xp = (x + 19) / 2f;
        }
        if (y == 12)
        {
            yp = -(y + 19) / 2f;
        }
        else if (y == 19)
        {
            yp = 0;
        }
        else
        {
            yp = (y + 19) / 2f;
        }
        if (z == 16)
        {
            zp = -(z + 19) / 2f;
        }
        else if (z == 19)
        {
            zp = 0;
        }
        else
        {
            zp = (z + 19) / 2f;
        }
        position = new Vector3(xp, yp, zp);
        scale = new Vector3(x-1,y-1,z - 1);
        GameObject cube = Instantiate(cubePrefab, position, transform.rotation,this.transform);
        cubeList.Add(cube);
        cube.transform.localScale = scale;
        Zuobiao zb= cube.GetComponent<Zuobiao>();
        zb.X = i;
        zb.Y = j;
        zb.Z = k;
        zuobiaoList.Add(zb);
    }
}
