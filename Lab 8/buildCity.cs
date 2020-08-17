using UnityEngine;
using System.Collections;

public class buildCity : MonoBehaviour {

    public GameObject[] buildings;
    public int mapWidth = 20;
    public int mapHeight = 20;
    public int buildingFootprint = 3;

    void Start ()
    {
        float seed = Random.Range(0,100);
        for(int h = 0; h < mapHeight; h++)
        {
            for(int w = 0; w < mapWidth; w++)
            {
                int result = (int) (Mathf.PerlinNoise(w/6.0f + seed,h/6.0f + seed) * 100);
                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                
                if(result < 8)
                    Instantiate(buildings[0], pos, Quaternion.Euler(-90, 0, Random.Range(-45,45)));
                else if(result < 16)
                    Instantiate(buildings[1], pos, Quaternion.Euler(0, 0, 0));
                else if(result < 24)
                    Instantiate(buildings[2], pos, Quaternion.Euler(-90, 0, Random.Range(-45,45)));
                else if(result < 32)
                    Instantiate(buildings[3], pos, Quaternion.Euler(-90, 0, Random.Range(-45,45)));
                else if(result < 40)
                    Instantiate(buildings[4], pos, Quaternion.Euler(-90, 0, Random.Range(-45,45)));
                else if(result < 48)
                    Instantiate(buildings[5], pos, Quaternion.Euler(-90, 0, Random.Range(-45,45)));
                else if(result < 56)
                    Instantiate(buildings[6], pos, Quaternion.Euler(-90, 0, Random.Range(-45,45)));
                else if(result < 64)
                    Instantiate(buildings[7], pos, Quaternion.Euler(0, 0, 0));
                else if(result < 72)
                    Instantiate(buildings[8], pos, Quaternion.Euler(-90, 0, Random.Range(-45,45)));
                else if(result < 80)
                    Instantiate(buildings[9], pos, Quaternion.Euler(-90, 0, Random.Range(-45,45)));
                else if(result < 88)
                    Instantiate(buildings[10], pos, Quaternion.Euler(-90, 0, Random.Range(-45,45)));
                else if(result < 96)
                    Instantiate(buildings[11], pos, Quaternion.Euler(0, 0, 0));
                else if(result < 100)
                    Instantiate(buildings[1], pos, Quaternion.Euler(180, 0, 0));
            }
        }
    }
}