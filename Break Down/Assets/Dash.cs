/*using UnityEngine;
using System.Collections;

public class GridControl : MonoBehaviour {
	
	public Color[] colorArr = new Color[5];
	
	void OnMouseDown (){
		
		string s = gameObject.name;
		int x = int.Parse (s.Substring (6, 2));
		int y = int.Parse (s.Substring (9, 2));
		Color work;
		
		Debug.Log ("x = " + x + "; y = " + y + "\n" +
		           "(x+1) = " + (x + 1) + "; (y+1) = " + (y + 1) +
		           "|| (x-1) = " + (x - 1) + "; (y-1) = " + (y - 1));
		//int i = x;
		int j = y;
		int mj = y;
		while (Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[x,j+1].GetComponent<SpriteRenderer> ().color) {
			
			Grid.grid [x, j + 1].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
			for (int z = x; z < x+1; z++) {
				
				for (int b = y; b < 19; b++) {
					
					if ((z >= 0 && z < 10) && (b >= 0 && b < 20)) {
						
						work = Grid.grid [z, b].GetComponent<SpriteRenderer> ().color; //Grid.grid[x,y+1];
						Grid.grid [z, b].GetComponent<SpriteRenderer> ().color = Grid.grid [z, b + 1].GetComponent<SpriteRenderer> ().color;
						Grid.grid [z, b + 1].GetComponent<SpriteRenderer> ().color = work;
					}
				}
			}
			j++;
			
		} 
		
		while (Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[x,mj -1].GetComponent<SpriteRenderer> ().color) {
			
			Grid.grid [x, mj - 1].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
			
			for (int u = x; u < x+1; u++) {
				
				for (int k = y; k < 19; k++) {
					
					if ((u >= 0 && u < 10) && (k >= 0 && k < 20)) {
						
						work = Grid.grid [u, k].GetComponent<SpriteRenderer> ().color; //Grid.grid[x,y+1];
						Grid.grid [u, k].GetComponent<SpriteRenderer> ().color = Grid.grid [u, k - 1].GetComponent<SpriteRenderer> ().color;
						Grid.grid [u, k - 1].GetComponent<SpriteRenderer> ().color = work;
					}
				}
			}
			mj--;
			
		}
		Grid.grid [x, y].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
		
		
		
		
		/*for (int i = x-1; i < x+2; i++) 
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
        }*/
		
		
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
        }
		
	}
	
	
	// Use this for initialization
	void Start () {
		int colorRand = Random.Range (0, 5);
		GetComponent<SpriteRenderer> ().color = colorArr[colorRand];
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}*/


/*(j - 1 > 0)&&(Grid.grid [x, y].GetComponent<SpriteRenderer> ().color == Grid.grid [x, j - 1].GetComponent<SpriteRenderer> ().color) |
		    (i + 1 > 10)&&(Grid.grid [x, y].GetComponent<SpriteRenderer> ().color == Grid.grid [i + 1, y].GetComponent<SpriteRenderer> ().color) |
		    (i - 1 > 0)&&(Grid.grid [x, y].GetComponent<SpriteRenderer> ().color == Grid.grid [i - 1, y].GetComponent<SpriteRenderer> ().color)) {


			while (Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[x, j + 1].GetComponent<SpriteRenderer> ().color) {
				Grid.grid [x, j + 1].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
				j++;
				gridCountY += 1;
			} 


			j = y;

			while (Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[x, j - 1].GetComponent<SpriteRenderer> ().color) {				
				Grid.grid [x, j - 1].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
				j--;
				gridCountY += 1;
			} 
			while (Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[i + 1, y].GetComponent<SpriteRenderer> ().color) {					
				Grid.grid [i + 1, y].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
				i++;
				gridCountXplus += 1;
			}
			i = x;

			while (Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[i - 1, y].GetComponent<SpriteRenderer> ().color) {					
				Grid.grid [i - 1, y].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
				i--;
				gridCountXminus += 1;
			}

			Grid.grid [x, y].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);*/

/*for (int c = x + 1 ; c < gridCountXplus; c++) {
				
				for (int a = y; a < 19; a++) {
					work = Grid.grid [c, a].GetComponent<SpriteRenderer> ().color;
					Grid.grid [c, a].GetComponent<SpriteRenderer> ().color = Grid.grid [c, a + 1].GetComponent<SpriteRenderer> ().color;
					Grid.grid [c, a + 1].GetComponent<SpriteRenderer> ().color = work;
				}
			}
			
			for (int n = x - 1 ; n > gridCountXminus; n--) {
				
				for (int m = y; m < 19; m++) {
					work = Grid.grid [n, m].GetComponent<SpriteRenderer> ().color;
					Grid.grid [n, m].GetComponent<SpriteRenderer> ().color = Grid.grid [n, m + 1].GetComponent<SpriteRenderer> ().color;
					Grid.grid [n, m + 1].GetComponent<SpriteRenderer> ().color = work;
				}
			}

			for (int q = 0; q < gridCountY; q++) {
			
				for (int b = j; b < 19; b++) {
					work = Grid.grid [x, b].GetComponent<SpriteRenderer> ().color;
					Grid.grid [x, b].GetComponent<SpriteRenderer> ().color = Grid.grid [x, b + 1].GetComponent<SpriteRenderer> ().color;
					Grid.grid [x, b + 1].GetComponent<SpriteRenderer> ().color = work;
				}
			}*/

/*void Direction (int xCor, int yCor) {

		int a = xCor;
		int b = yCor;


		if ((yCor + 1 < 20) && (Grid.grid [xCor, yCor].GetComponent<SpriteRenderer> ().color == Grid.grid [xCor, yCor + 1].GetComponent<SpriteRenderer> ().color)) {

			while (b + 1 < 20 && Grid.grid[xCor, yCor].GetComponent<SpriteRenderer> ().color == Grid.grid[xCor, b + 1].GetComponent<SpriteRenderer> ().color) {

				Grid.grid [xCor, b + 1].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
				b++;
				Direction (xCor, b +1);
			}
		}

		b = yCor;
			
		if ((yCor > 0) && (Grid.grid [xCor, yCor].GetComponent<SpriteRenderer> ().color == Grid.grid [xCor, yCor - 1].GetComponent<SpriteRenderer> ().color)) {
				
			while (b -1 >= 0 &&  Grid.grid[xCor, yCor].GetComponent<SpriteRenderer> ().color == Grid.grid[xCor, b - 1].GetComponent<SpriteRenderer> ().color) {	

				Grid.grid [xCor, b - 1].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
				b--;
				Direction (xCor, b - 1);
			} 
		}
			
			
		if ((xCor + 1 < 10) && (Grid.grid [xCor, yCor].GetComponent<SpriteRenderer> ().color == Grid.grid [xCor + 1, yCor].GetComponent<SpriteRenderer> ().color)) {

			while (a + 1 < 10 && Grid.grid[xCor, yCor].GetComponent<SpriteRenderer> ().color == Grid.grid[a + 1, yCor].GetComponent<SpriteRenderer> ().color) {

				Grid.grid [a + 1, yCor].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
				a++;
				Direction (a + 1, yCor);
			}
		}
			
		a = xCor;
			
		if ((xCor > 0) && (Grid.grid [xCor, yCor].GetComponent<SpriteRenderer> ().color == Grid.grid [xCor - 1, yCor].GetComponent<SpriteRenderer> ().color)) {

			while (a - 1 >= 0 && Grid.grid[xCor, yCor].GetComponent<SpriteRenderer> ().color == Grid.grid[a - 1, yCor].GetComponent<SpriteRenderer> ().color) {	

				Grid.grid [a - 1, yCor].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
				a--;
				Direction (a - 1, yCor);
			}
		}
	}*/
/*if ((y + 1 < 20) && (Grid.grid [x, y].GetComponent<SpriteRenderer> ().color == Grid.grid [x, y + 1].GetComponent<SpriteRenderer> ().color)) {

			while (j + 1 < 20 && Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[x, j + 1].GetComponent<SpriteRenderer> ().color) {
				Direction (x, j + 1);
				Grid.grid [x, j + 1].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
				j++;
			}
		}

		j = y;

		if ((y > 0) && (Grid.grid [x, y].GetComponent<SpriteRenderer> ().color == Grid.grid [x, y - 1].GetComponent<SpriteRenderer> ().color)) {

			while (j -1 >= 0 &&  Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[x, j - 1].GetComponent<SpriteRenderer> ().color) {				
				Direction (x, j - 1);		
				Grid.grid [x, j - 1].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
				j--;
			}
		}

		if ((x + 1 < 10) && (Grid.grid [x, y].GetComponent<SpriteRenderer> ().color == Grid.grid [x + 1, y].GetComponent<SpriteRenderer> ().color)) {

			while (i + 1 < 10 && Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[i + 1, y].GetComponent<SpriteRenderer> ().color) {					
				Direction (i + 1, y);	
				Grid.grid [i + 1, y].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
				i++;
			}
		}

		i = x;

		if ((x > 0) && (Grid.grid [x, y].GetComponent<SpriteRenderer> ().color == Grid.grid [x - 1, y].GetComponent<SpriteRenderer> ().color)) {

			while (i - 1 >= 0 && Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[i - 1, y].GetComponent<SpriteRenderer> ().color) {					
				Direction (i - 1, y);		
				Grid.grid [i - 1, y].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
				i--;
			}
		}
	
		Grid.grid [x, y].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);*/



