using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour
{
	public GameObject objetoAInstanciar;
    public Transform lugar;
	private bool IsAvailable = true;
	private float CooldownDuration = 1.0f;	

    private void Update()
    {
        if (IsAvailable &&  Input.GetKeyDown(KeyCode.Space))
        {		
				Shoot();
		}			
    }
	
	private void Shoot()
	{
		Debug.Log("The Cannon has been shoot!");
		Instantiate(objetoAInstanciar,lugar.position,transform.rotation);
		StartCoroutine(StartCooldown());		
	}

	public IEnumerator StartCooldown()
	{
		IsAvailable = false;
		yield return new WaitForSeconds(CooldownDuration);
		IsAvailable = true;
	}

}
