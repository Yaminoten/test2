using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoClicker : MonoBehaviour {

	public long m_compteur;
	public float m_timer;
	public long m_firstMember;
	public long m_secondMember;
	public long m_thirdMember;
	public long m_fourthMember;
	public long m_fifthMember;
	public long m_sixthMember;
	public long m_seventhMember;
	public long m_eighthMember;
	public long m_ninthMember;
	public Text m_score;
	public GameObject m_buttonFirst;
	public Text m_textFirst;
	public GameObject m_buttonSecond;
	public Text m_textSecond;
	public GameObject m_buttonThird;
	public Text m_textThird;
	public GameObject m_buttonFourth;
	public Text m_textFourth;
	public GameObject m_buttonFifth;
	public Text m_textFifth;
	public GameObject m_buttonSixth;
	public Text m_textSixth;
	public GameObject m_buttonSeventh;
	public Text m_textSeventh;
	public GameObject m_buttonEighth;
	public Text m_textEighth;
	public GameObject m_buttonNinth;
	public Text m_textNinth;
	public Text m_numberFirst;
	public Text m_numberSecond;
	public Text m_numberThird;
	public Text m_numberFourth;
	public Text m_numberFifth;
	public Text m_numberSixth;
	public Text m_numberSeventh;
	public Text m_numberEighth;
	public Text m_numberNinth;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update()
	{
		m_score.GetComponent<Text>().text = m_compteur.ToString();
		if (m_firstMember != 0)
		{
			m_timer = 10f/m_firstMember;
			StartCoroutine(IncrementFirst());
		}
		if (m_secondMember != 0)
		{
			m_timer = 10f/m_secondMember;
			StartCoroutine(IncrementSecond());
		}
		if (m_thirdMember != 0)
		{
			m_timer = 10f / m_thirdMember;
			StartCoroutine(IncrementThird());
		}
		if (m_fourthMember != 0)
		{
			m_timer = 10f / m_fourthMember;
			StartCoroutine(IncrementFourth());
		}
		if (m_fifthMember != 0)
		{
			m_timer = 10f / m_fifthMember;
			StartCoroutine(IncrementFifth());
		}
		if (m_sixthMember != 0)
		{
			m_timer = 10f / m_sixthMember;
			StartCoroutine(IncrementSixth());
		}
		if (m_seventhMember != 0)
		{
			m_timer = 10f / m_seventhMember;
			StartCoroutine(IncrementSeventh());
		}
		if (m_eighthMember != 0)
		{
			m_timer = 10f / m_eighthMember;
			StartCoroutine(IncrementEighth());
		}
		if (m_ninthMember != 0)
		{
			m_timer = 10f / m_ninthMember;
			StartCoroutine(IncrementNinth());
		}
		if (m_compteur >= 10)
		{
			m_buttonFirst.SetActive(true);
		}
		if (m_compteur >= 100)
		{
			m_buttonSecond.SetActive(true);
		}
		if (m_compteur >= Mathf.Pow(10, 3))
		{
			m_buttonThird.SetActive(true);
		}
		if (m_compteur >= Mathf.Pow(10, 4))
		{
			m_buttonFourth.SetActive(true);
		}
		if (m_compteur >= Mathf.Pow(10, 5))
		{
			m_buttonFifth.SetActive(true);
		}
		if (m_compteur >= Mathf.Pow(10, 6))
		{
			m_buttonSixth.SetActive(true);
		}
		if (m_compteur >= Mathf.Pow(10, 7))
		{
			m_buttonSeventh.SetActive(true);
		}
		if (m_compteur >= Mathf.Pow(10, 8))
		{
			m_buttonEighth.SetActive(true);
		}
		if (m_compteur >= Mathf.Pow(10, 9))
		{
			m_buttonNinth.SetActive(true);
		}
	}

	public void PlusOne()
	{
		m_compteur++;
	}

	public void AddFirst()
	{
		if (m_compteur >= 10 * Mathf.Pow(m_firstMember + 1, .5f))
		{
			float temp = 10 * Mathf.Pow(m_firstMember + 1 , .5f);
			m_compteur = m_compteur - Convert.ToInt64(temp);
			m_firstMember++;
			temp = 10 * Mathf.Pow(m_firstMember + 1, .5f);
			long conv = Convert.ToInt64(temp);
			m_textFirst.text = conv.ToString();
			m_numberFirst.text = m_firstMember.ToString();
		}
	}
	public void AddSecond()
	{
		if (m_compteur >= 100 * Mathf.Pow(m_secondMember + 1, .5f))
		{
			float temp = 100 * Mathf.Pow(m_secondMember + 1, .5f);
			m_compteur = m_compteur - Convert.ToInt64(temp);
			m_secondMember++;
			temp = 100 * Mathf.Pow(m_secondMember + 1, .5f);
			long conv = Convert.ToInt64(temp);
			m_textSecond.text = conv.ToString();
			m_numberSecond.text = m_secondMember.ToString();
		}
	}
	public void AddThird()
	{
		if (m_compteur >= 1000 * Mathf.Pow(m_thirdMember + 1, .5f))
		{
			float temp = 1000 * Mathf.Pow(m_thirdMember + 1, .5f);
			m_compteur = m_compteur - Convert.ToInt64(temp);
			m_thirdMember++;
			temp = 1000 * Mathf.Pow(m_thirdMember + 1, .5f);
			long conv = Convert.ToInt64(temp);
			m_textThird.text = conv.ToString();
			m_numberThird.text = m_thirdMember.ToString();
		}
	}
	public void AddFourth()
	{
		if (m_compteur >= 10000 * Mathf.Pow(m_fourthMember + 1, .5f))
		{
			float temp = 10000 * Mathf.Pow(m_fourthMember + 1, .5f);
			m_compteur = m_compteur - Convert.ToInt64(temp);
			m_fourthMember++;
			temp = 10000 * Mathf.Pow(m_fourthMember + 1, .5f);
			long conv = Convert.ToInt64(temp);
			m_textFourth.text = conv.ToString();
			m_numberFourth.text = m_fourthMember.ToString();
		}
	}
	public void AddFifth()
	{
		if (m_compteur >= 100000 * Mathf.Pow(m_fifthMember + 1, .5f))
		{
			float temp = 100000 * Mathf.Pow(m_fifthMember + 1, .5f);
			m_compteur = m_compteur - Convert.ToInt64(temp);
			m_fifthMember++;
			temp = 100000 * Mathf.Pow(m_fifthMember + 1, .5f);
			long conv = Convert.ToInt64(temp);
			m_textFifth.text = conv.ToString();
			m_numberFifth.text = m_fifthMember.ToString();
		}
	}
	public void AddSixth()
	{
		if (m_compteur >= 1000000 * Mathf.Pow(m_sixthMember + 1, .5f))
		{
			float temp = 1000000 * Mathf.Pow(m_sixthMember + 1, .5f);
			m_compteur = m_compteur - Convert.ToInt64(temp);
			m_sixthMember++;
			temp = 1000000 * Mathf.Pow(m_sixthMember + 1, .5f);
			long conv = Convert.ToInt64(temp);
			m_textSixth.text = conv.ToString();
			m_numberSixth.text = m_sixthMember.ToString();
		}
	}
	public void AddSeventh()
	{
		if (m_compteur >= 10000000 * Mathf.Pow(m_seventhMember + 1, .5f))
		{
			float temp = 10000000 * Mathf.Pow(m_seventhMember + 1, .5f);
			m_compteur = m_compteur - Convert.ToInt64(temp);
			m_seventhMember++;
			temp = 10000000 * Mathf.Pow(m_seventhMember + 1, .5f);
			long conv = Convert.ToInt64(temp);
			m_textSeventh.text = conv.ToString();
			m_numberSeventh.text = m_seventhMember.ToString();
		}
	}
	public void AddEighth()
	{
		if (m_compteur >= 100000000 * Mathf.Pow(m_eighthMember + 1, .5f))
		{
			float temp = 100000000 * Mathf.Pow(m_eighthMember + 1, .5f);
			m_compteur = m_compteur - Convert.ToInt64(temp);
			m_eighthMember++;
			temp = 100000000 * Mathf.Pow(m_eighthMember + 1, .5f);
			long conv = Convert.ToInt64(temp);
			m_textEighth.text = conv.ToString();
			m_numberEighth.text = m_eighthMember.ToString();
		}
	}
	public void AddNinth()
	{
		if (m_compteur >= 1000000000 * Mathf.Pow(m_ninthMember + 1, .5f))
		{
			float temp = 1000000000 * Mathf.Pow(m_secondMember + 1, .5f);
			m_compteur = m_compteur - Convert.ToInt64(temp);
			m_ninthMember++;
			temp = 1000000000 * Mathf.Pow(m_ninthMember + 1, .5f);
			long conv = Convert.ToInt64(temp);
			m_textNinth.text = conv.ToString();
			m_numberNinth.text = m_ninthMember.ToString();
		}
	}
	IEnumerator IncrementFirst()
	{
		if (m_canIncrease == true)
		{
			m_canIncrease = false;
			yield return new WaitForSeconds(m_timer);
			m_compteur++;
			m_canIncrease = true;
		}
	}
	IEnumerator IncrementSecond()
	{
		if (m_canIncrease2 == true)
		{
			m_canIncrease2 = false;
			yield return new WaitForSeconds(m_timer);
			m_compteur += 10;
			m_canIncrease2 = true;
		}
	}
	IEnumerator IncrementThird()
	{
		if (m_canIncrease3 == true)
		{
			m_canIncrease3 = false;
			yield return new WaitForSeconds(m_timer);
			m_compteur += 100;
			m_canIncrease3 = true;
		}
	}
	IEnumerator IncrementFourth()
	{
		if (m_canIncrease4 == true)
		{
			m_canIncrease4 = false;
			yield return new WaitForSeconds(m_timer);
			m_compteur += 1000;
			m_canIncrease4 = true;
		}
	}
	IEnumerator IncrementFifth()
	{
		if (m_canIncrease5 == true)
		{
			m_canIncrease5 = false;
			yield return new WaitForSeconds(m_timer);
			m_compteur += 10000;
			m_canIncrease5 = true;
		}
	}
	IEnumerator IncrementSixth()
	{
		if (m_canIncrease6 == true)
		{
			m_canIncrease6 = false;
			yield return new WaitForSeconds(m_timer);
			m_compteur += 100000;
			m_canIncrease6 = true;
		}
	}
	IEnumerator IncrementSeventh()
	{
		if (m_canIncrease7 == true)
		{
			m_canIncrease7 = false;
			yield return new WaitForSeconds(m_timer);
			m_compteur += 1000000;
			m_canIncrease7 = true;
		}
	}
	IEnumerator IncrementEighth()
	{
		if (m_canIncrease8 == true)
		{
			m_canIncrease8 = false;
			yield return new WaitForSeconds(m_timer);
			m_compteur += 10000000;
			m_canIncrease8 = true;
		}
	}
	IEnumerator IncrementNinth()
	{
		if (m_canIncrease9 == true)
		{
			m_canIncrease9 = false;
			yield return new WaitForSeconds(m_timer);
			m_compteur += 100000000;
			m_canIncrease9 = true;
		}
	}


	private bool m_canIncrease = true;
	private bool m_canIncrease2 = true;
	private bool m_canIncrease3 = true;
	private bool m_canIncrease4 = true;
	private bool m_canIncrease5= true;
	private bool m_canIncrease6 = true;
	private bool m_canIncrease7 = true;
	private bool m_canIncrease8 = true;
	private bool m_canIncrease9 = true;
}
