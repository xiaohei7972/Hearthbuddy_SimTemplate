using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_064 : SimTemplate //* 祖达克仪祭师 Zul'Drak Ritualist
	{
		//[x]<b>Taunt</b> <b>Battlecry:</b> Summon threerandom 1-Cost minionsfor your opponent.
		//<b>嘲讽，战吼：</b>随机为你的对手召唤三个法力值消耗为（1）的随从。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_189);//精灵弓箭手
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int pos = (own.own) ? p.enemyMinions.Count : p.ownMinions.Count ;
			p.callKid(kid, pos, !own.own);
			p.callKid(kid, pos, !own.own);
			p.callKid(kid, pos, !own.own);
		}
		
	}
}
