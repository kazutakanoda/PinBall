using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	//スコアを表示するテキスト
	private GameObject ScoreText;
	// Materialを入れる
	Material myMaterial;

	//スコアを出すための点数
	private int TotalScore = 0;

	//小さな星に当たった時の点数
	private int SmallStarScore = 10;
	//大きな星に当たった時の点数
	private int LargeStarScore = 20;
	//小さな雲に当たった時の点数
	private int SmallCloudScore = 15;
	//大きな雲に当たった時の点数
	private int LargeCloudScore = 25;

	// Use this for initialization
	void Start () {

		this.ScoreText = GameObject.Find("ScoreText");

		this.ScoreText.GetComponent<Text> ().text = "Score:" + TotalScore;
			
	}

	//cube同士での衝突＋100 cube以外との衝突＋100
	void OnCollisionEnter( Collision collision )
	{
		//衝突したタグを取得
		string Tag  = collision.gameObject.tag;

		// タグによって加算する点数を変える
		if (Tag == "SmallStarTag") {
			TotalScore = TotalScore + SmallStarScore;
		} else if (Tag == "LargeStarTag") {
			TotalScore = TotalScore + LargeStarScore;
		} else if (Tag == "SmallCloudTag") {
			TotalScore = TotalScore + SmallCloudScore;
		} else if (Tag == "LargeCloudTag") {
			TotalScore = TotalScore + LargeCloudScore;
		}

		this.ScoreText.GetComponent<Text> ().text = "Score:" + TotalScore;
	}
}


