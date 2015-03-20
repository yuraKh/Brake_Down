using UnityEngine;
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
		int i = x;
		int j = y;
		int gridCountXplus = 1;
		int gridCountXminus = 1;
		int gridCountY = 1;


			
		if ((Grid.grid [x, y].GetComponent<SpriteRenderer> ().color == Grid.grid [x, y + 1].GetComponent<SpriteRenderer> ().color) |
			(Grid.grid [x, y].GetComponent<SpriteRenderer> ().color == Grid.grid [x, y - 1].GetComponent<SpriteRenderer> ().color) |
			(Grid.grid [x, y].GetComponent<SpriteRenderer> ().color == Grid.grid [x + 1, y].GetComponent<SpriteRenderer> ().color) |
			(Grid.grid [x, y].GetComponent<SpriteRenderer> ().color == Grid.grid [x - 1, y].GetComponent<SpriteRenderer> ().color)) {


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

			Grid.grid [x, y].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);

			for (int c = x + 1 ; c < gridCountXplus; c++) {
				
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
}