using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_086: SimTemplate //* 冰封秘典 Glacial Mysteries
//Put one of each <b>Secret</b> from your deck intothe battlefield.
//将每种不同的<b>奥秘</b>从你的牌库中置入战场。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
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

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_SECRET_ZONE_CAP_FOR_NON_SECRET),
            };
        }
	}
}