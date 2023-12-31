using UnityEngine;

namespace Move.Script
{
    /// <summary>
    /// 滑动球体
    /// </summary>
    public class MovingSphere : MonoBehaviour
    {
        /// <summary>
        /// 最大加速度
        /// </summary>
        [SerializeField, Range(0f, 100f)] private float maxAcceleration = 10f;

        /// <summary>
        /// 最大速度
        /// </summary>
        [SerializeField, Range(0f, 100f)] private float maxSpeed = 10f;

        /// <summary>
        /// 球的移动范围
        /// </summary>
        [SerializeField] private Rect allowedArea = new Rect(-5f, -5f, 10f, 10f);

        /// <summary>
        /// 球的弹力
        /// </summary>
        [SerializeField, Range(0f, 1f)] private float bounciness = 0.5f;

        /// <summary>
        /// 当前速度
        /// </summary>
        private Vector3 _velocity;

        private void Update()
        {
            Vector2 playerInput;
            playerInput.x = Input.GetAxis("Horizontal");
            playerInput.y = Input.GetAxis("Vertical");

            //让球仿照摇杆的方式在一个半径为1的圆内移动
            // playerInput.Normalize(); //将向量归一化
            // playerInput = Vector2.ClampMagnitude(playerInput, 1f); //确保向量大小不会超过1
            // transform.localPosition = new Vector3(playerInput.x, 0.5f, playerInput.y);

            Vector3 desiredVelocity =
                new Vector3(playerInput.x, 0f, playerInput.y) * maxSpeed;
            float maxSpeedChange = maxAcceleration * Time.deltaTime;
            //if (_velocity.x < desiredVelocity.x) {
            //	_velocity.x =
            //		Mathf.Min(velocity.x + maxSpeedChange, desiredVelocity.x);
            //}
            //else if (_velocity.x > desiredVelocity.x) {
            //	_velocity.x =
            //		Mathf.Max(velocity.x - maxSpeedChange, desiredVelocity.x);
            //}
            //当前速度_velocity向目标速度desiredVelocity接近，接近速度maxSpeedChange
            _velocity.x =
                Mathf.MoveTowards(_velocity.x, desiredVelocity.x, maxSpeedChange);
            _velocity.z =
                Mathf.MoveTowards(_velocity.z, desiredVelocity.z, maxSpeedChange);

            Vector3 displacement = _velocity * Time.deltaTime;
            Vector3 newPosition = transform.localPosition + displacement;
            // if (!allowedArea.Contains(new Vector2(newPosition.x, newPosition.z))) //进行越界检测
            // {
            //     //newPosition = transform.localPosition;
            //     //消除移动到边缘时的抖动
            //     newPosition.x =
            //         Mathf.Clamp(newPosition.x, allowedArea.xMin, allowedArea.xMax);
            //     newPosition.z =
            //         Mathf.Clamp(newPosition.z, allowedArea.yMin, allowedArea.yMax);
            // }
            //到达边缘以后要清除速度
            if (newPosition.x < allowedArea.xMin)
            {
                newPosition.x = allowedArea.xMin;
                _velocity.x = -_velocity.x * bounciness;
            }
            else if (newPosition.x > allowedArea.xMax)
            {
                newPosition.x = allowedArea.xMax;
                _velocity.x = -_velocity.x * bounciness;
            }

            if (newPosition.z < allowedArea.yMin)
            {
                newPosition.z = allowedArea.yMin;
                _velocity.z = -_velocity.x * bounciness;
            }
            else if (newPosition.z > allowedArea.yMax)
            {
                newPosition.z = allowedArea.yMax;
                _velocity.z = -_velocity.x * bounciness;
            }

            transform.localPosition = newPosition;
        }
    }
}