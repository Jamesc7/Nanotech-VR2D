using UnityEngine;
using System.Collections;
using Valve.VR;

namespace Valve.VR.InteractionSystem
{
    public class ObjectShake : MonoBehaviour
    {

        private Vector3 originPosition;
        private Quaternion originRotation;
        public float shake_decay = 0.002f;
        public float shake_intensity = .3f;
        float timer = 0;
        public Hand right;
        public Hand left;

        private float temp_shake_intensity = 0;

        private void Start()
        {
            //hand = GetComponent<Hand>();
        }

        void Update()
        {
            if (gameObject.CompareTag("Vibrate")) //GameObject: Naden
            {
                timer += Time.deltaTime;
                if (timer > .3 && timer < 1.7f)
                {
                    Shake();
                    right.TriggerHapticPulse(1000);
                    left.TriggerHapticPulse(1000);
                }

            }
            else if (gameObject.CompareTag("Vibrate2")) //GameObject: Folate + NADPH + DHFR (With Hydrogen)
            {
                timer += Time.deltaTime;
                if (timer >= 9.5f)
                {
                    Shake();
                    if (timer < 10.9)
                    {
                        right.TriggerHapticPulse(1000);
                        left.TriggerHapticPulse(1000);
                    }

                }

            }
            else if (gameObject.CompareTag("Vibrate3")) //GameObject: Folate + NADPH + DHFR (With Hydrogen), Node_1
            {
                timer += Time.deltaTime;
                if (timer <= 2.5f)
                {
                    Shake();
                    right.TriggerHapticPulse(1000);
                    left.TriggerHapticPulse(1000);
                }
            }
            
            else
            {
                Shake();
            }
            if (temp_shake_intensity > 0)
            {
                transform.position = originPosition + Random.insideUnitSphere * temp_shake_intensity;
                transform.rotation = new Quaternion(
                    originRotation.x + Random.Range(-temp_shake_intensity, temp_shake_intensity) * .2f,
                    originRotation.y + Random.Range(-temp_shake_intensity, temp_shake_intensity) * .2f,
                    originRotation.z + Random.Range(-temp_shake_intensity, temp_shake_intensity) * .2f,
                    originRotation.w + Random.Range(-temp_shake_intensity, temp_shake_intensity) * .2f);
                temp_shake_intensity -= shake_decay;
            }
        }

        void Shake()
        {
            originPosition = transform.position;
            originRotation = transform.rotation;
            temp_shake_intensity = shake_intensity;

        }
    }
}
