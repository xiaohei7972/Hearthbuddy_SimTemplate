using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_429p2 : SimTemplate //* 恶魔冲击 Demonic Blast
	{
		//[x]<b>Hero Power</b>Deal $4 damage.<i>(Last use!)</i>
		//<b>英雄技能</b>造成$4点伤害。<i>（还可使用一次！）</i>
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int dmg = (ownplay) ? p.getHeroPowerDamage(4) : p.getEnemyHeroPowerDamage(4);
			p.minionGetDamageOrHeal(target, dmg);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 只能是敌方
            };
        }
	}
}
