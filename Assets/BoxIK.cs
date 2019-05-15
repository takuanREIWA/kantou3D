using UnityEngine;
using System.Collections;

public class BoxIK : MonoBehaviour {

	//　右手位置用のTransform
	[SerializeField]
	private Transform rightHandTransform;
	private Animator animator;

	void Start () {
		animator = GetComponent<Animator>();
	}

	void OnAnimatorIK() {
		//右手のIK設定
		animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
		animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
		animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandTransform.position);
		animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandTransform.rotation);
	}
}
