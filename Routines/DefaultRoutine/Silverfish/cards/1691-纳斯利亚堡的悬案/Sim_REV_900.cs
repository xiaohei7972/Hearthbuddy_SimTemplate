using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_REV_900 : SimTemplate //* 谣言食尸鬼 Scuttlebutt Ghoul
	{
									//* 嘲讽，战吼：如果你控制一个奥秘，便召唤一个该随从的复制。
									//* Taunt Battlecry: If you control a Secret, summon a copy of this.
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.callKid(own.handcard.card, own.zonepos, own.own);
			int secretsCount = (own.own) ? p.ownSecretsIDList.Count : p.enemySecretList.Count;			
			List<Minion> temp= (own.own) ? p.ownMinions : p.enemyMinions;
			foreach(Minion mnn in temp)
			{
				if( mnn.name == CardDB.cardNameEN.scuttlebuttghoul && own.entitiyID != mnn.entitiyID && mnn.playedThisTurn)
				{
					mnn.setMinionToMinion(own);
					break;
				}
			}
		}
    }
}
