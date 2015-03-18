using UnityEngine;
using System.Collections;

public class GridControl : MonoBehaviour {
	
	public Color[] colorArr = new Color[5];
	GameObject work;
	
	void OnMouseDown (){
		string s = gameObject.name;
		int x = int.Parse(s[6].ToString());
		int y = int.Parse(s[8].ToString());
		for (int i = x-1; i < x+2; i++) {
			for (int j = y-1; j < y+2; j++) {
				if ((i >= 0 && i<6) && (j >= 0 && j <10)) {
					if (Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[i,j].GetComponent<SpriteRenderer> ().color) {
						//if (Mathf.Abs(i) != Mathf.Abs(j)) {
						Grid.grid[i,j].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
						if (Grid.grid[i,j].GetComponent<SpriteRenderer> ().color == new Color (0f, 0f, 0f, 0.255f)) {

							work = Grid.grid[x, y];
							Grid.grid[x, y] = Grid.grid[x, 10];
							Grid.grid[x, 10] = work;


						}
							//Debug.Log(x + " x " + y + " y " + i + " i " + j + " j ");
						//}		
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
}