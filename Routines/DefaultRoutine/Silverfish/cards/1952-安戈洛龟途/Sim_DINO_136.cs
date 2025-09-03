using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：4
	//Horn of Feasting
	//盛宴之角
	//Summon three2/1 Raptors with <b>Rush</b>.<b>Outcast:</b> Give them <b>Immune</b>while attacking this turn.
	//召唤三只2/1并具有<b>突袭</b>的迅猛龙。<b>流放：</b>使其在本回合中获得攻击时<b>免疫</b>。
	class Sim_DINO_136 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DINO_136t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);

		}
		
		public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_CAP,1),
			};
        }
		
	}
}
