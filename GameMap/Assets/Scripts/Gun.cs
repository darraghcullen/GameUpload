using UnityEngine;

public class Gun : MonoBehaviour
{
        public float damage = 10f;
        public float range = 100f;
        AudioSource shootingSound;
        [SerializeField] Camera cam;

        void Update()
        {
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));
            if (Physics.Raycast(ray, out RaycastHit hit ))
            {
                Target target = hit.collider.gameObject.GetComponent<Target>();
                if(target != null)
                {
                    Destroy(target.gameObject);
                }
            }

        }
              
}