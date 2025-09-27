using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：5
	//Swarm of Lightbugs
	//萤光虫群
	//Summon 10 1/1 Lightbugs with <b>Lifesteal</b>. Save any excess ina 1-Cost Bottle.
	//召唤10只1/1并具有<b>吸血</b>的萤光虫。将超过随从数量上限的萤光虫存入法力值消耗为（1）的瓶子。
	class Sim_WW_052 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WW_052t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			for (int i = 0; i < 10; i++)
			{
				p.callKid(kid, pos, ownplay);
			}

		}

		public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_CAP,1),
			};
        }

	}
}
