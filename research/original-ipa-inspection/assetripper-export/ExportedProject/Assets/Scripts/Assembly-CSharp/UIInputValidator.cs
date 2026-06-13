using UnityEngine;

[RequireComponent(typeof(UIInput))]
[AddComponentMenu("NGUI/Interaction/Input Validator")]
public class UIInputValidator : MonoBehaviour
{
	public enum Validation
	{
		None = 0,
		Integer = 1,
		Float = 2,
		Alphanumeric = 3,
		Username = 4,
		Name = 5
	}

	public Validation logic;

	private void Start()
	{
	}

	private char Validate(string text, char ch)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
