using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：3
	//Stag Charge
	//雄鹿冲锋
	//Deal $3 damage. Summon a random <b>Dormant</b> Wildseed.
	//造成$3点伤害。随机召唤一个<b>休眠</b>的灵种。
	class Sim_REV_364 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.minionGetDamageOrHeal(target, dmg);
			//TODO：随即召唤灵种
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }		
		
	}
}
