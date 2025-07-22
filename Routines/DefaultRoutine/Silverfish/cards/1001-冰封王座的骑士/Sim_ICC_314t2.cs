using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ICC_314t2 : SimTemplate //* 亡者大军 Army of the Dead
//Remove the top 5 cards of your deck. Summon any minions removed.
//移除你的牌库顶的五张牌。召唤其中所有被移除的随从。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            int anz = (ownplay) ? p.ownDeckSize : p.enemyDeckSize;
            if (anz > 5) anz = 5;
            if (ownplay) p.ownDeckSize -= anz;
            else p.enemyDeckSize -= anz;

            if (anz > 0) p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_120), pos, ownplay, false);
            if (anz > 2) p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS1_042), pos, ownplay, false);
            if (anz > 4) p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_048), pos, ownplay, false);
        }
    }
}