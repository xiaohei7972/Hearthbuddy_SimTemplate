using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：4
	//Sheep Mask
	//绵羊面具
	//Set a minion's stats to 1/1 and give it "<b>Deathrattle:</b> Deal 2 damage to all minions."
	//将一个随从的属性值变为1/1并使其获得“<b>亡语：</b>对所有随从造成2点伤害。”
	class Sim_DINO_429 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionSetAngrToX(target, 1);
				p.minionSetLifetoX(target, 1);
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
