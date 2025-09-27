using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 无效的 费用：2
	//Twin Blades
	//双刃
	//[x]Give a friendly minion andyour hero +$a1 Attack thisturn and <b>Divine Shield</b>.
	//使一个友方随从和你的英雄获得<b>圣盾</b>以及本回合中的+$a1攻击力。
	class Sim_SC_754p : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			Minion hero = ownplay ? p.ownHero : p.enemyHero;
			if (target != null)
			{
				target.divineshild = true;
				hero.divineshild = true;
			}
			else
			{
				hero.divineshild = true;
			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
			};
		}
	}
}
