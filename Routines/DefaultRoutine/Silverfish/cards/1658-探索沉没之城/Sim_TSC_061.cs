using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：10
	//The Garden's Grace
	//花园惠景
	//[x]Give a minion +4/+4 and<b>Divine Shield</b>. Costs (1) lessfor each Mana you've spenton Holy spells this game.
	//使一个随从获得+4/+4和<b>圣盾</b>。在本局对战中，你每消耗1点法力值用于神圣法术牌上，本牌的法力值消耗便减少（1）点。
	class Sim_TSC_061 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 4, 4);
				target.divineshild = true;
			}
		}
		
		public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
			};
        }
	}
}
