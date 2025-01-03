using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Animator muzzleFlashAnimator;
    
    public GunData playerData;
    public FriendsGunData friendsData;
    public GunAnimationData animationData;

    private int currentLevel;

    public void PlayMuzzleFlashVfx()
    {
        muzzleFlashAnimator.SetTrigger("Flash");
    }

    public float GetPlayerFirePower()
    {
        return playerData.firePower;
    }

    public float GetPlayerShootSpeed()
    {
        return playerData.speed;
    }
    
}
