using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Laser Barrage
	//激光弹幕
	//Deal $3 damageto a minion. If you're building a <b>Starship</b>, also damage its neighbors.
	//对一个随从造成$3点伤害。如果你正在构筑<b>星舰</b>，则还会对相邻随从造成伤害。
	class Sim_GDB_845 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                int damage = ownplay ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
                // 对一个随从造成3点伤害
                p.minionGetDamageOrHeal(target, damage);
				//TODO:没有星舰代码
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]{
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
			};
        }
		
	}
}
