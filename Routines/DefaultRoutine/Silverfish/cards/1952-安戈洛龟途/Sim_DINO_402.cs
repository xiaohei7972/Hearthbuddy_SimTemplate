using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：8
	//Bat Mask
	//蝙蝠面具
	//Set a friendly minion's stats to 1/1. Fill your board with copies of it.
	//将一个友方随从的属性值变为1/1。用它的复制填满你的面板。
	class Sim_DINO_402 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionSetAngrToX(target, 1);
				p.minionSetLifetoX(target, 1);
				for (int i = 0; i < 7 - p.ownMinions.Count; i++)
				{
					p.callKid(target.handcard.card, target.zonepos, target.own);
				}
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
			};
        }
		
	}
}
