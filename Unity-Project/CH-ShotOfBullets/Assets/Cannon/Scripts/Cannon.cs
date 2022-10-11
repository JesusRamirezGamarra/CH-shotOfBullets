using UnityEngine;

public class Cannon : MonoBehaviour
{
	public GameObject objetoAInstanciar;
    public Transform lugar;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
			Shoot();
		}
    }
	
	private void Shoot()
	{
		Debug.Log("The Cannon has been shoot!");
		Instantiate(objetoAInstanciar,lugar.position,transform.rotation);
	}
}
