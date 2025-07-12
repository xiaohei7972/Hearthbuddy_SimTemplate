using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 中立 费用：2
	//Frost Bullet
	//冰霜枪弹
	//Deal $2 damage.Gain $d4 Armor.Swaps each turn.
	//造成$2点伤害。获得$d4点护甲值。每回合切换。
	class Sim_WW_0700p2 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int damage = ownplay ? p.getHeroPowerDamage(2) : p.getEnemyHeroPowerDamage(2);
				p.minionGetDamageOrHeal(target, damage);
				p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, 4);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
			};
        }
		
	}
}
