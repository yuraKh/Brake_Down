using UnityEngine;
using System.Collections;

public class GridControl : MonoBehaviour {
	
	public Color[] colorArr = new Color[5];
	
	void OnMouseDown (){
		string s = gameObject.name;
		int x = int.Parse(s.Substring(6,2));
		int y = int.Parse(s.Substring(9,2));
		//GameObject work;
		/*if ((x >= 0 && x<10) && (y >= 0 && y <20)) {
				if (Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[x+1 ,y].GetComponent<SpriteRenderer> ().color)
				{
					Grid.grid[x,y].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);

					if (Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[x-1 ,y].GetComponent<SpriteRenderer> ().color)
					{
						Grid.grid[x-1,y].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
						
						if (Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[x ,y+1].GetComponent<SpriteRenderer> ().color)
						{
							Grid.grid[x,y+1].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
							
							if (Grid.grid[x,y].GetComponent<SpriteRenderer> ().color == Grid.grid[x ,y-1].GetComponent<SpriteRenderer> ().color)
							{
								Grid.grid[x,y-1].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
							}
						}
					}
				}
			}*/
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
						//if (Mathf.Abs(i) == Mathf.Abs(j)) 
						//{
							//break;
						/*}
						else
						{*/
							Grid.grid[i,j].GetComponent<SpriteRenderer> ().color = new Color (0f, 0f, 0f, 0.255f);
							/*if (Grid.grid[i,j].GetComponent<SpriteRenderer> ().color == new Color (0f, 0f, 0f, 0.255f))
							{

								work = Grid.grid[x, y];
								Grid.grid[x, y] = Grid.grid[x, 10];
								Grid.grid[x, 10] = work;


							}*/

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