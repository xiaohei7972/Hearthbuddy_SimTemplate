using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 巫妖王 费用：2
	//Ghoul Frenzy
	//食尸鬼狂暴
	//[x]<b>Hero Power</b>Summon a 2/1 Ghoulwith <b>Charge</b>. It dies atend of turn.
	//<b>英雄技能</b>召唤一个2/1并具有<b>冲锋</b>的食尸鬼。它会在回合结束时死亡。
	class Sim_HERO_11bp2 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.HERO_11bp2t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay, false);
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1), //确保有位置召唤
            };
		}

		

	}
}
