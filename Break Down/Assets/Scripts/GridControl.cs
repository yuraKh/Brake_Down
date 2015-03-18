using UnityEngine;
using System.Collections;

public class GridControl : MonoBehaviour {
	
	public Color[] colorArr = new Color[5];
	
	void OnMouseDown (){

		string s = gameObject.name;
		int x = int.Parse(s.Substring(6,2));
		int y = int.Parse(s.Substring(9,2));
        Color work;
		
		Debug.Log("x = " + x +  "; y = " + y + "\n" +
		          "(x+1) = " + (x + 1) + "; (y+1) = " + (y+1) +
		          "|| (x-1) = " + (x - 1) + "; (y-1) = " + (y-1));
        for (int i = x-1; i < x+2; i++) 
        {
            for (int j = y-1; j < y+2; j++) 
            {
                
                if ((i >= 0 && i<10) && (j >= 0 && j <20)) 
                {
                    if (Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[i,j].GetComponent<SpriteRenderer> ().color) 
                    {                        
                       Grid.grid[i,j].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
                        if (Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == new Color (0f, 0f, 0f, 0.255f))
                        {
                            for(int z = x-1; z < x+2; z++)
                            {
                                for(int b = y-1; b < 19; b++)
                                {
                                    if ((z >= 0 && z<10) && (b >= 0 && b <20)) 
                                    {
                                        work = Grid.grid[z,b].GetComponent<SpriteRenderer> ().color; //Grid.grid[x,y+1];
                                        Grid.grid[z, b].GetComponent<SpriteRenderer> ().color = Grid.grid[z, b+1].GetComponent<SpriteRenderer> ().color;
                                        Grid.grid[z, b+1].GetComponent<SpriteRenderer> ().color = work;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
            

       /* Grid.grid[x,y].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
        if (Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == new Color (0f, 0f, 0f, 0.255f))
        {
            for(int i = x; i < x+1; i++)
            {
                for(int j = y; j < 19; j++)
                {
                    if ((i >= 0 && i<10) && (j >= 0 && j <20)) 
                    {
                        work = Grid.grid[i,j].GetComponent<SpriteRenderer> ().color; //Grid.grid[x,y+1];
                        Grid.grid[x, j].GetComponent<SpriteRenderer> ().color = Grid.grid[x, j+1].GetComponent<SpriteRenderer> ().color;
                        Grid.grid[x, j+1].GetComponent<SpriteRenderer> ().color = work;
                    }
                }
            }
        }*/
	}
	
	// Use this for initialization
	void Start () {
		int colorRand = Random.Range (0, 5);
		GetComponent<SpriteRenderer> ().color = colorArr[colorRand];
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}