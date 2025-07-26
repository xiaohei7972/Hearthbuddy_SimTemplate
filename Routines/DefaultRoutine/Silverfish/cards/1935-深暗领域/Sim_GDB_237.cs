using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：5
	//Alien Encounters
	//接触异星生物
	//Summon two 2/4 Beasts with <b>Taunt</b>. Costs(1) less for each card you <b><b>Discover</b>ed</b> this game.
	//召唤两只2/4并具有<b>嘲讽</b>的野兽。在本局对战中你每<b><b>发现</b>过</b>一张牌，本牌的法力值消耗便减少（1）点。
	class Sim_GDB_237 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GDB_237t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_MINION_CAP,1), // 需要一个空位
			};
        }
		
	}
}
