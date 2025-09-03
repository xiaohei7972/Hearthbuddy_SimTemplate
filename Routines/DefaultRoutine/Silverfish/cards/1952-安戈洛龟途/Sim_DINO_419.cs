using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：3 生命值：2
	//Herbivore Assistant
	//饲草助手
	//<b>Battlecry:</b> Give a friendly Beast +2/+2 and <b>Rush</b>.
	//<b>战吼：</b>使一只友方野兽获得+2/+2和<b>突袭</b>。
	class Sim_DINO_419 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionGetBuffed(target, 2, 2);
				p.minionGetRush(target);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE,20),
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),

			};
		}
	}
}
