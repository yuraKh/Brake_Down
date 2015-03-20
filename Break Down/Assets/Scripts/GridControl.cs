using UnityEngine;
using System.Collections;

public class GridControl : MonoBehaviour {
	
	public Color[] colorArr = new Color[5];

	Color Fon;
	
	void Direction (int a, int b){

		Color work;
		if (a + 1 < 10 && Fon == Grid.grid [a + 1, b].GetComponent<SpriteRenderer> ().color) {
			Grid.grid [a + 1, b].GetComponent<SpriteRenderer> ().color = Color.clear;

			/*for (int i = b; i < 19; i++) {
				work = Grid.grid [a + 1, i].GetComponent<SpriteRenderer> ().color;
				Grid.grid [a + 1, i].GetComponent<SpriteRenderer> ().color = Grid.grid [a + 1, i + 1].GetComponent<SpriteRenderer> ().color;
				Grid.grid [a + 1, i + 1].GetComponent<SpriteRenderer> ().color = work;
			}*/
			Direction (a + 1, b);
		}
		if (a > 0 && Fon == Grid.grid [a - 1, b].GetComponent<SpriteRenderer> ().color) {
			Grid.grid [a - 1, b].GetComponent<SpriteRenderer> ().color = Color.clear;

			/*for (int i = b; i < 19; i++) {
				work = Grid.grid [a - 1, i].GetComponent<SpriteRenderer> ().color;
				Grid.grid [a - 1, i].GetComponent<SpriteRenderer> ().color = Grid.grid [a - 1, i + 1].GetComponent<SpriteRenderer> ().color;
				Grid.grid [a - 1, i + 1].GetComponent<SpriteRenderer> ().color = work;
			}*/
			Direction (a - 1, b);
		}
		if (b + 1 < 20 && Fon == Grid.grid [a, b + 1].GetComponent<SpriteRenderer> ().color) {
			Grid.grid [a, b + 1].GetComponent<SpriteRenderer> ().color = Color.clear;
		
			/*for (int i = b + 1; i < 19; i++) {
				work = Grid.grid [a, i].GetComponent<SpriteRenderer> ().color;
				Grid.grid [a , i].GetComponent<SpriteRenderer> ().color = Grid.grid [a , i + 1].GetComponent<SpriteRenderer> ().color;
				Grid.grid [a, i + 1].GetComponent<SpriteRenderer> ().color = work;
			}*/
			Direction (a, b + 1);
		}
		if (b > 0 && Fon == Grid.grid [a, b - 1].GetComponent<SpriteRenderer> ().color) {
			Grid.grid [a, b - 1].GetComponent<SpriteRenderer> ().color = Color.clear;

			/*for (int i = b - 1; i < 19; i++) {
				work = Grid.grid [a, i].GetComponent<SpriteRenderer> ().color;
				Grid.grid [a , i].GetComponent<SpriteRenderer> ().color = Grid.grid [a , i + 1].GetComponent<SpriteRenderer> ().color;
				Grid.grid [a, i + 1].GetComponent<SpriteRenderer> ().color = work;
			}*/
			Direction (a, b - 1);
		}
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 20; j++) {
				if (Grid.grid [a , j].GetComponent<SpriteRenderer> ().color == Color.clear) {
					for (int c = j; c < 19; c++) {
						work = Grid.grid [a, c].GetComponent<SpriteRenderer> ().color;
						Grid.grid [a , c].GetComponent<SpriteRenderer> ().color = Grid.grid [a , c + 1].GetComponent<SpriteRenderer> ().color;
						Grid.grid [a, c + 1].GetComponent<SpriteRenderer> ().color = work;
					}
				}
			}
		}
	}


		
	void OnMouseDown () {

		string s = gameObject.name;
		int x = int.Parse (s.Substring (6, 2));
		int y = int.Parse (s.Substring (9, 2));
		Fon = Grid.grid [x, y].GetComponent<SpriteRenderer> ().color;
		/*Debug.Log ("x = " + x + "; y = " + y + "\n" +
			"(x+1) = " + (x + 1) + "; (y+1) = " + (y + 1) +
			"|| (x-1) = " + (x - 1) + "; (y-1) = " + (y - 1));*/
	
		Direction (x, y);
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