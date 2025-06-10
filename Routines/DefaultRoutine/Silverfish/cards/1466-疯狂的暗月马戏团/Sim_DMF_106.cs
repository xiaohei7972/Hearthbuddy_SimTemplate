using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_106 : SimTemplate //* 隐秘咒术师 Occult Conjurer
	{
		//<b>Battlecry:</b> If you control a <b>Secret</b>, summon a copy of_this.
		//<b>战吼：</b>如果你控制一个<b>奥秘</b>，便召唤一个该随从的复制。
		//CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DMF_106);//隐秘咒术师
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.callKid(own.handcard.card, own.zonepos, own.own);
			int secretsCount = (own.own) ? p.ownSecretsIDList.Count : p.enemySecretList.Count;			
			List<Minion> temp= (own.own) ? p.ownMinions : p.enemyMinions;
			foreach(Minion mnn in temp)
			{
				if( mnn.name == CardDB.cardNameEN.occultconjurer && own.entitiyID != mnn.entitiyID && mnn.playedThisTurn)
				{
					mnn.setMinionToMinion(own);
					break;
				}
			}
		}
		
	}
}
