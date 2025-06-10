using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_508 : SimTemplate //* 试炼场 Proving Grounds
    {
        //从你的牌库中召唤两个随从，并使其互相攻击！
        //Summon two minions from your deck. They fight!
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int cnt = 2;
            // 遍历卡组
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
               
                int pos = p.ownMinions.Count;
                p.callKid(deckMinion, pos, ownplay);
                p.minionGetBuffed(p.ownMinions[pos], p.deckAngrBuff, p.deckHpBuff);
                cnt--;
                if (cnt <= 0) break;
                
            }
        }
    }
}
