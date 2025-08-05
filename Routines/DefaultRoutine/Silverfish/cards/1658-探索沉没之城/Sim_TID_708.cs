using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：3
	//Polymorph: Jellyfish
	//变形术：水母
	//Transform a minioninto a 4/1 Jellyfish with <b>Spell Damage +2</b>.
	//将一个随从变形成为一只4/1并具有<b>法术伤害+2</b>的水母。
	class Sim_TID_708 : SimTemplate
	{
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TID_708t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionTransform(target, card);
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), //需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), //目标只能是随从
            };
		}
	}
}
