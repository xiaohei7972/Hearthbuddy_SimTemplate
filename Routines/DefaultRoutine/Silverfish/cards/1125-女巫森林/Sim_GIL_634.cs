using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_634 : SimTemplate //* 警钟哨卫 Bellringer Sentry
//<b>Battlecry and Deathrattle:</b> Put a <b>Secret</b> from your deck into the battlefield.
//<b>战吼，亡语：</b>将一个<b>奥秘</b>从你的牌库中置入战场。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                List<CardDB.cardIDEnum> secrets = new List<CardDB.cardIDEnum>();
                CardDB.Card c;
                foreach (KeyValuePair<CardDB.cardIDEnum, int> cid in p.prozis.turnDeck)
                {
                    c = CardDB.Instance.getCardDataFromID(cid.Key);
                    if (c.Secret) secrets.Add(cid.Key);
                }

                foreach (CardDB.cardIDEnum cId in secrets)
                {
                    if (p.ownSecretsIDList.Count < 5 && !p.ownSecretsIDList.Contains(cId)) p.ownSecretsIDList.Add(cId);
                }
            }
            else
            {
                for (int i = p.enemySecretCount; i < 5; i++)
                {
                    p.enemySecretCount++;
                    p.enemySecretList.Add(Probabilitymaker.Instance.getNewSecretGuessedItem(p.getNextEntity(), p.enemyHeroStartClass));
                }
            }
        }
	}
}