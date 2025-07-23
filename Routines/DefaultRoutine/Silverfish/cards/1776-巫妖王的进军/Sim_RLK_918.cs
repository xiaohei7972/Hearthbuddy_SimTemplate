using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：2
	//For Quel'Thalas!
	//为了奎尔萨拉斯！
	//[x]Give a friendly minion+3 Attack. Give your hero+2 Attack this turn.
	//使一个友方随从获得+3攻击力。在本回合中，使你的英雄获得+2攻击力。
	class Sim_RLK_918 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

			if (target != null)
			{
				p.minionGetBuffed(target, 3, 0);
			}
			Minion hero = ownplay ? p.ownHero : p.enemyHero;
			p.minionGetTempBuff(hero, 2, 0);
            hero.updateReadyness();

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 只能是随从
			};
		}

	}
}
